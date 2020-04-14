using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCons5 : MonoBehaviour
{
    Collider LeftThumbPalm;
    Collider LeftIndexPalm;
    Collider TouchpointZ;

    Collider LeftIndexTip;

    Collider LeftThumbMiddle;
    Collider LeftIndexMiddle;
    Collider LeftMiddleMid;
    Collider LeftRingMiddle;
    Collider LeftPinkyMiddle;

    Collider RightIndexTip;
    Collider RightMiddleTip;
    Collider RightRingTip;

    Collider RightThumbMiddle;
    Collider RightIndexMiddle;
    Collider RightMiddleMid;
    Collider RightRingMiddle;
    Collider RightPinkyMiddle;

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

        FindLeftColliders();
        FindRightColliders();
    }

    void Update()
    {
        CheckCollision();
    }

    private void FindRightColliders()
    {
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
        RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();

        RightThumbMiddle = GameObject.FindGameObjectWithTag("RightThumbMid").GetComponent<CapsuleCollider>();
        RightIndexMiddle = GameObject.FindGameObjectWithTag("RightIndexMid").GetComponent<CapsuleCollider>();
        RightMiddleMid = GameObject.FindGameObjectWithTag("RightMiddleMid").GetComponent<CapsuleCollider>();
        RightRingMiddle = GameObject.FindGameObjectWithTag("RightRingMid").GetComponent<CapsuleCollider>();
        RightPinkyMiddle = GameObject.FindGameObjectWithTag("RightPinkyMid").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {      
        LeftThumbPalm = GameObject.FindGameObjectWithTag("LeftThumbPalm").GetComponent<CapsuleCollider>();
        LeftIndexPalm = GameObject.FindGameObjectWithTag("LeftIndexPalm").GetComponent<BoxCollider>();
        TouchpointZ = GameObject.FindGameObjectWithTag("TouchpointZ").GetComponent<BoxCollider>();

        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();

        LeftThumbMiddle = GameObject.FindGameObjectWithTag("LeftThumbMid").GetComponent<CapsuleCollider>();
        LeftIndexMiddle = GameObject.FindGameObjectWithTag("LeftIndexMid").GetComponent<CapsuleCollider>();
        LeftMiddleMid = GameObject.FindGameObjectWithTag("LeftMiddleMid").GetComponent<CapsuleCollider>();
        LeftRingMiddle = GameObject.FindGameObjectWithTag("LeftRingMid").GetComponent<CapsuleCollider>();
        LeftPinkyMiddle = GameObject.FindGameObjectWithTag("LeftPinkyMid").GetComponent<CapsuleCollider>();
    }

    private void CheckCollision()
    {
        // V
        if (RightIndexTip.bounds.Intersects(LeftThumbPalm.bounds) &&
            RightMiddleTip.bounds.Intersects(LeftIndexPalm.bounds))
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
        if (RightThumbMiddle.bounds.Intersects(LeftThumbMiddle.bounds) &&
            RightIndexMiddle.bounds.Intersects(LeftIndexMiddle.bounds) &&
            RightMiddleMid.bounds.Intersects(LeftMiddleMid.bounds) &&
            RightRingMiddle.bounds.Intersects(LeftRingMiddle.bounds) &&
            RightPinkyMiddle.bounds.Intersects(LeftPinkyMiddle.bounds))
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
        if (RightIndexTip.bounds.Intersects(LeftIndexTip.bounds))
        {
            Debug.Log("X");
            XSigned = true;
            XPracticed = true;
        }
        else
        {
            XSigned = false;
        }

        // Y
        if (RightIndexTip.bounds.Intersects(LeftThumbPalm.bounds))
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
        if (RightIndexTip.bounds.Intersects(TouchpointZ.bounds) &&
            RightMiddleTip.bounds.Intersects(TouchpointZ.bounds) &&
            RightRingTip.bounds.Intersects(TouchpointZ.bounds))
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
