using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCons4 : MonoBehaviour
{
    Collider LeftThumbTip;
    Collider LeftThumbMiddle;
    Collider LeftIndexTip;
    Collider LeftPinkyBot;

    Collider LeftPinkyPalm;

    Collider RightIndexTip;
    Collider RightIndexMiddle;
        
    public bool QSigned;
    public bool RSigned;
    public bool SSigned;
    public bool TSigned;

    public bool QPracticed;
    public bool RPracticed;
    public bool SPracticed;
    public bool TPracticed;

    //public GameObject leftHand;
    //public GameObject rightHand;

    void Start()
    {
        QSigned = false;
        RSigned = false;
        SSigned = false;
        TSigned = false;

        QPracticed = false;
        RPracticed = false;
        SPracticed = false;
        TPracticed = false;

        FindLeftColliders();
        FindRightColliders();
    }

    void Update()
    {
        CheckCollision();
    }

    private void FindRightColliders()
    {
        //RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightIndexMiddle = GameObject.FindGameObjectWithTag("RightIndexMid").GetComponent<CapsuleCollider>();
        //RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();

        //RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();
        //RightPinkyTip = GameObject.FindGameObjectWithTag("RightPinkyTip").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {
        LeftThumbTip = GameObject.FindGameObjectWithTag("LeftThumbTip").GetComponent<CapsuleCollider>();
        LeftThumbMiddle = GameObject.FindGameObjectWithTag("LeftThumbMid").GetComponent<CapsuleCollider>();
        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        LeftPinkyBot = GameObject.FindGameObjectWithTag("LeftPinkyBot").GetComponent<CapsuleCollider>();

        LeftPinkyPalm = GameObject.FindGameObjectWithTag("LeftPinkyPalm").GetComponent<BoxCollider>();

        //LeftMiddleBot = GameObject.FindGameObjectWithTag("LeftMiddleBot").GetComponent<CapsuleCollider>();
        //LeftMiddleMid = GameObject.FindGameObjectWithTag("LeftMiddleMid").GetComponent<CapsuleCollider>();

        //LeftMiddleTip = GameObject.FindGameObjectWithTag("LeftMiddleTip").GetComponent<CapsuleCollider>();
        //LeftRingTip = GameObject.FindGameObjectWithTag("LeftRingTip").GetComponent<CapsuleCollider>();
        //LeftPinkyTip = GameObject.FindGameObjectWithTag("LeftPinkyTip").GetComponent<CapsuleCollider>();
    }

    private void CheckCollision()
    {
        // Q
        if (LeftIndexTip.bounds.Intersects(LeftThumbTip.bounds) &&
            RightIndexTip.bounds.Intersects(LeftThumbMiddle.bounds))
        {
            Debug.Log("Q");
            QSigned = true;
            QPracticed = true;
        }
        else
        {
            QSigned = false;
        }

        // R
        if (RightIndexTip.bounds.Intersects(LeftPinkyPalm.bounds) &&
            RightIndexMiddle.bounds.Intersects(LeftPinkyPalm.bounds))
        {
            Debug.Log("R");
            RSigned = true;
            RPracticed = true;
        }
        else
        {
            RSigned = false;
        }

        // S
        if (RightIndexTip.bounds.Intersects(LeftPinkyBot.bounds))
        {
            Debug.Log("S");
            SSigned = true;
            SPracticed = true;
        }
        else
        {
            SSigned = false;
        }

        // T
        if (RightIndexTip.bounds.Intersects(LeftPinkyPalm.bounds))
        {
            Debug.Log("T");
            TSigned = true;
            TPracticed = true;
        }
        else
        {
            TSigned = false;
        }
    }
}
