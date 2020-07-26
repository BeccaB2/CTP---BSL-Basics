using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCollision : MonoBehaviour 
{
    Collider DTButtonCollider;
    Collider MTButtonCollider;

    Material light;
    Material dark;

    //public GameObject parentForHands;

    //public GameObject leftHand;
    //public GameObject rightHand;
    //public Collider leftIndex;
    //public Collider rightIndex;

    // Use this for initialization
    void Start()
    {
        dark = Resources.Load<Material>("ButtonDark");
        light = Resources.Load<Material>("ButtonLight");

        if (SceneManager.GetActiveScene().name == "Menu")
        {          
            DTButtonCollider = GameObject.FindGameObjectWithTag("StartDT").GetComponent<CapsuleCollider>();
            MTButtonCollider = GameObject.FindGameObjectWithTag("StartMT").GetComponent<CapsuleCollider>();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Mouse control
        MouseAction();

        // Find the colliders for each hand & checks for button press
        //HandControl();
    }

    private void MouseAction()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(Camera.main.transform.position, 
            Camera.main.ScreenPointToRay(Input.mousePosition).direction, Color.red);

        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit))
        {
            if (SceneManager.GetActiveScene().name == "Menu")
            {
                MenuButtons(hit);
            }
        }
        else 
        {
            if (SceneManager.GetActiveScene().name == "Menu")
            {
                DTButtonCollider.gameObject.GetComponent<Renderer>().material = dark;
                MTButtonCollider.gameObject.GetComponent<Renderer>().material = dark;
            }
        }
    }

    private void MenuButtons(RaycastHit hit)
    {
        if (hit.collider.tag == DTButtonCollider.gameObject.tag)
        {
            Debug.Log("DTHit");
            DTButtonCollider.gameObject.GetComponent<Renderer>().material = light;

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Clicky");
                SceneManager.LoadScene(1);
            }             
        }
        else
        {
            DTButtonCollider.gameObject.GetComponent<Renderer>().material = dark;
        }
        
        if (hit.collider.tag == MTButtonCollider.gameObject.tag)
        {
            Debug.Log("MTHit");
            MTButtonCollider.gameObject.GetComponent<Renderer>().material = light;

            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Clicky");
                SceneManager.LoadScene(6);
            }              
        }
        else
        {
            MTButtonCollider.gameObject.GetComponent<Renderer>().material = dark;
        }
    }

    /*
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
   */

    //void OnMouseDown()
    //{
    //    Debug.Log("Clicky");
    //}

    /*
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
    */
}
