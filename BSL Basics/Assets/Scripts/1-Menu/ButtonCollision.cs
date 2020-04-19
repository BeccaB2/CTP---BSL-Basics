using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCollision : MonoBehaviour {

    public Collider buttonCollider;
    public Collider leftIndex;
    public Collider rightIndex;

    //public GameObject parentForHands;

    public GameObject leftHand;
    public GameObject rightHand;

    // Use this for initialization
    void Start ()
    {
        buttonCollider = GameObject.FindGameObjectWithTag("StartButton").GetComponent<CapsuleCollider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Find the colliders for each hand & check for button press
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
