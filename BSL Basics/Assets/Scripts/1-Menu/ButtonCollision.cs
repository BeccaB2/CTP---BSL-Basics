using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCollision : MonoBehaviour 
{
    public Collider buttonCollider;
    public Collider leftIndex;
    public Collider rightIndex;

    //public GameObject parentForHands;

    public GameObject leftHand;
    public GameObject rightHand;

    // Use this for initialization
    void Start()
    {
        buttonCollider = GameObject.FindGameObjectWithTag("StartButton").GetComponent<CapsuleCollider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Mouse control
        MouseAction();

        // Find the colliders for each hand & check for button press
        //HandControl();
    }

    private void HandControl()
    {
        if (rightHand.activeInHierarchy != false)
        {
            rightIndex = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
            RightButtonPress();
        }
        else
        {
            rightIndex = null;
        }

        if (leftHand.activeInHierarchy != false)
        {
            leftIndex = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
            LeftButtonPress();
        }
        else
        {
            leftIndex = null;
        }
    }

    private void MouseAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicky");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(Camera.main.transform.position, Camera.main.ScreenPointToRay(Input.mousePosition).direction, Color.red);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == buttonCollider.gameObject.tag)
                {
                    Debug.Log("Hit");
                    SceneManager.LoadScene(1);
                }
            }
            else
            {
                Debug.Log("Miss");
            }
        }
    }

    //void OnMouseDown()
    //{
    //    Debug.Log("Clicky");
    //}

    private void LeftButtonPress()
    {
        if (leftIndex.bounds.Intersects(buttonCollider.bounds))
        {
            Debug.Log("BUTTONL");
            SceneManager.LoadScene(1);
        }
    }

    private void RightButtonPress()
    {
        if (rightIndex.bounds.Intersects(buttonCollider.bounds))
        {
            Debug.Log("BUTTONR");
            SceneManager.LoadScene(1);
        }
    }
}
