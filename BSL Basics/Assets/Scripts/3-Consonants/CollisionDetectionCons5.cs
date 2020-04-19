using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionCons5 : MonoBehaviour
{
    GameObject hands;
    FindColliders colliders;

    public bool VSigned;
    public bool WSigned;
    public bool XSigned;
    public bool YSigned;
    public bool ZSigned;

    public bool VPracticed;
    public bool WPracticed;
    public bool XPracticed;
    public bool YPracticed;
    public bool ZPracticed;

    void Start()
    {
        // Initialising booleans
        InitBools();

        // Finding hands and colliders
        FindHandsAndColliders();
    }

    private void InitBools()
    {
        VSigned = false;
        WSigned = false;
        XSigned = false;
        YSigned = false;
        ZSigned = false;

        VPracticed = false;
        WPracticed = false;
        XPracticed = false;
        YPracticed = false;
        ZPracticed = false;
    }

    private void FindHandsAndColliders()
    {
        // Finding the hand object
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

    void Update()
    {
        CheckCollision();
    }

    private void CheckCollision()
    {
        // V
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftThumbCreaseFront.bounds) &&
            colliders.RightMiddleTip.bounds.Intersects(colliders.LeftIndexPalm.bounds))
        {
            Debug.Log("V");
            VSigned = true;
            VPracticed = true;
        }
        else
        {
            VSigned = false;
        }

        // W
        if (colliders.RightThumbMid.bounds.Intersects(colliders.LeftThumbMid.bounds) &&
            colliders.RightIndexMid.bounds.Intersects(colliders.LeftIndexMid.bounds) &&
            colliders.RightMiddleMid.bounds.Intersects(colliders.LeftMiddleMid.bounds) &&
            colliders.RightRingMid.bounds.Intersects(colliders.LeftRingMid.bounds) &&
            colliders.RightPinkyMid.bounds.Intersects(colliders.LeftPinkyMid.bounds))
        {
            Debug.Log("W");
            WSigned = true;
            WPracticed = true;
        }
        else
        {
            WSigned = false;
        }

        // X
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexTip.bounds))
        {
            Debug.Log("X");
            XSigned = true;
            XPracticed = true;
        }
        else
        {
            XSigned = false;
        }

        // Y //CHANGE THE COLLIDER TO BACK???
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftThumbCreaseFront.bounds))
        {
            Debug.Log("Y");
            YSigned = true;
            YPracticed = true;
        }
        else
        {
            YSigned = false;
        }

        // Z
        if (colliders.RightIndexTip.bounds.Intersects(colliders.TouchpointZ.bounds) &&
            colliders.RightMiddleTip.bounds.Intersects(colliders.TouchpointZ.bounds) &&
            colliders.RightRingTip.bounds.Intersects(colliders.TouchpointZ.bounds))
        {
            Debug.Log("Z");
            ZSigned = true;
            ZPracticed = true;
        }
        else
        {
            ZSigned = false;
        }
    }
}
