using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandClosureChecking : MonoBehaviour
{
    GameObject hands;
    FindColliders colliders;

    public bool LeftThumbOpen;
    public bool LeftIndexOpen;
    public bool LeftMiddleOpen;
    public bool LeftRingOpen;
    public bool LeftPinkyOpen;

    public bool RightThumbOpen;
    public bool RightIndexOpen;
    public bool RightMiddleOpen;
    public bool RightRingOpen;
    public bool RightPinkyOpen;

    public bool LeftAllOpen;
    public bool LeftAllClosed;

    public bool RightAllOpen;
    public bool RightAllClosed;

    public bool OnlyRightIndexOpen;

    // Use this for initialization
    void Start()
    {
        // Initialise booleans
        InitBools();

        // Finding hands and colliders
        FindHandsAndColliders();
    }

    private void InitBools()
    {
        LeftThumbOpen = false;
        LeftIndexOpen = false;
        LeftMiddleOpen = false;
        LeftRingOpen = false;
        LeftPinkyOpen = false;

        RightThumbOpen = false;
        RightIndexOpen = false;
        RightMiddleOpen = false;
        RightRingOpen = false;
        RightPinkyOpen = false;

        LeftAllOpen = false;
        LeftAllClosed = false;

        RightAllOpen = false;
        RightAllClosed = false;

        OnlyRightIndexOpen = false;
    }

    private void FindHandsAndColliders()
    {
        // Finding the correct hand object
        if (SceneManager.GetActiveScene().name == "MountedHandDemo" ||
            SceneManager.GetActiveScene().name == "VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }

        colliders = hands.GetComponent<FindColliders>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckCollision();
    }

    private void CheckCollision()
    {
        LeftHand();
        RightHand();
    }

    private void LeftHand()
    {
        //THUMB MESSES ABOUT
        //(colliders.LeftThumbTip.bounds.Intersects(colliders.LeftClosed.bounds)

        // Full fist closure - uses thumb over the fingers to check if closed
        if (colliders.LeftThumbTip.bounds.Intersects(colliders.LeftIndexMid.bounds) &&
            colliders.LeftThumbTip.bounds.Intersects(colliders.LeftMiddleMid.bounds) &&
            LeftIndexOpen == false && LeftMiddleOpen == false && 
            LeftRingOpen == false &&  LeftPinkyOpen == false)
        {
            Debug.Log("CLOSED HAND - LEFT");
            LeftAllClosed = true;
            RightAllOpen = false;
        }
        else
        {
            LeftAllClosed = false;
        }

        // Check if all fingers are open
        if (LeftThumbOpen == true && LeftIndexOpen == true &&
            LeftMiddleOpen == true && LeftRingOpen == true && LeftPinkyOpen == true)
        {
            LeftAllOpen = true;
        }
        else
        {
            LeftAllOpen = false;
        }

        // Thumb
        if (colliders.LeftThumbTip.bounds.Intersects(colliders.LeftClosed.bounds))
        {
            Debug.Log("CLOSED LEFT THUMB");
            LeftThumbOpen = false;
        }
        else
        {
            LeftThumbOpen = true;
        }

        // Index
        if (colliders.LeftIndexTip.bounds.Intersects(colliders.LeftClosed.bounds))
        {
            Debug.Log("CLOSED LEFT INDEX");
            LeftIndexOpen = false;
        }
        else
        {
            LeftIndexOpen = true;
        }

        // Middle
        if (colliders.LeftMiddleTip.bounds.Intersects(colliders.LeftClosed.bounds))
        {
            Debug.Log("CLOSED LEFT MIDDLE");
            LeftMiddleOpen = false;
        }
        else
        {
            LeftMiddleOpen = true;
        }

        // Ring
        if (colliders.LeftRingTip.bounds.Intersects(colliders.LeftClosed.bounds))
        {
            Debug.Log("CLOSED LEFT RING");
            LeftRingOpen = false;
        }
        else
        {
            LeftRingOpen = true;
        }

        // Pinky
        if (colliders.LeftPinkyTip.bounds.Intersects(colliders.LeftClosed.bounds))
        {
            Debug.Log("CLOSED LEFT PINKY");
            LeftPinkyOpen = false;
        }
        else
        {
            LeftPinkyOpen = true;
        }
    }

    private void RightHand()
    {
        // Full fist closure
        if (colliders.RightThumbTip.bounds.Intersects(colliders.RightIndexMid.bounds) &&
            colliders.RightThumbTip.bounds.Intersects(colliders.RightMiddleMid.bounds) &&
            RightIndexOpen == false && RightMiddleOpen == false && 
            RightRingOpen == false && RightPinkyOpen == false)
        {
            Debug.Log("CLOSED HAND - RIGHT");
            RightAllClosed = true;
            RightAllOpen = false;
        }
        else
        {
            RightAllClosed = false;           
        }

        // Checking if all fingers are open
        if (RightThumbOpen == true && RightIndexOpen == true &&
            RightMiddleOpen == true && RightRingOpen == true && RightPinkyOpen == true)
        {
            RightAllOpen = true;
        }
        else
        {
            RightAllOpen = false;
        }

        // Thumb
        if (colliders.RightThumbTip.bounds.Intersects(colliders.RightClosed.bounds))
        {
            Debug.Log("CLOSED RIGHT THUMB");
            RightThumbOpen = false;
        }
        else
        {
            RightThumbOpen = true;
        }

        // Index
        if (colliders.RightIndexTip.bounds.Intersects(colliders.RightClosed.bounds))
        {
            Debug.Log("CLOSED RIGHT INDEX");
            RightIndexOpen = false;
        }
        else
        {
            RightIndexOpen = true;
        }

        // Middle
        if (colliders.RightMiddleTip.bounds.Intersects(colliders.RightClosed.bounds))
        {
            Debug.Log("CLOSED RIGHT MIDDLE");
            RightMiddleOpen = false;
        }
        else
        {
            RightMiddleOpen = true;
        }

        // Ring
        if (colliders.RightRingTip.bounds.Intersects(colliders.RightClosed.bounds))
        {
            Debug.Log("CLOSED RIGHT RING");
            RightRingOpen = false;
        }
        else
        {
            RightRingOpen = true;
        }

        // Pinky
        if (colliders.RightPinkyTip.bounds.Intersects(colliders.RightClosed.bounds))
        {
            Debug.Log("CLOSED RIGHT PINKY");
            RightPinkyOpen = false;
        }
        else
        {
            RightPinkyOpen = true;
        }

        // Checking if only index is open
        if(RightThumbOpen == false && RightMiddleOpen == false && 
           RightRingOpen == false && RightPinkyOpen == false && RightIndexOpen == true)
        {
            OnlyRightIndexOpen = true;
        }
        else
        {
            OnlyRightIndexOpen = false;
        }
    }
}
