using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCons5 : MonoBehaviour
{
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

    public GameObject leftHand;
    public GameObject rightHand;

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

        //FindLeftColliders();
        //FindRightColliders();
    }

    void Update()
    {
        CheckCollision();
    }

    private void FindRightColliders()
    {
        //RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();
        //RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        //RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();

        //RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();
        //RightPinkyTip = GameObject.FindGameObjectWithTag("RightPinkyTip").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {
        //LeftThumbTip = GameObject.FindGameObjectWithTag("LeftThumbTip").GetComponent<CapsuleCollider>();
        //LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        //LeftIndexBot = GameObject.FindGameObjectWithTag("LeftIndexBot").GetComponent<CapsuleCollider>();
        //LeftMiddleBot = GameObject.FindGameObjectWithTag("LeftMiddleBot").GetComponent<CapsuleCollider>();
        //LeftMiddleMid = GameObject.FindGameObjectWithTag("LeftMiddleMid").GetComponent<CapsuleCollider>();

        //LeftMiddleTip = GameObject.FindGameObjectWithTag("LeftMiddleTip").GetComponent<CapsuleCollider>();
        //LeftRingTip = GameObject.FindGameObjectWithTag("LeftRingTip").GetComponent<CapsuleCollider>();
        //LeftPinkyTip = GameObject.FindGameObjectWithTag("LeftPinkyTip").GetComponent<CapsuleCollider>();
    }

    private void CheckCollision()
    {
        // V
        //if (/*LeftIndexTip.bounds.Intersects(RightIndexTip.bounds)*/)
        //{
        //    Debug.Log("V");
        //    VSigned = true;
        //    VPracticed = true;
        //}
        //else
        //{
        //    VSigned = false;
        //}

        // W
        //if ()
        //{
        //    Debug.Log("W");
        //    WSigned = true;
        //    WPracticed = true;
        //}
        //else
        //{
        //    WSigned = false;
        //}

        // X
        //if ()
        //{
        //    Debug.Log("X");
        //    XSigned = true;
        //    XPracticed = true;
        //}
        //else
        //{
        //    XSigned = false;
        //}

        // Y
        //if ()
        //{
        //    Debug.Log("Y");
        //    YSigned = true;
        //    YPracticed = true;
        //}
        //else
        //{
        //    YSigned = false;
        //}

        // Z
        //if ()
        //{
        //    Debug.Log("Z");
        //    ZSigned = true;
        //    ZPracticed = true;
        //}
        //else
        //{
        //    ZSigned = false;
        //}
    }
}
