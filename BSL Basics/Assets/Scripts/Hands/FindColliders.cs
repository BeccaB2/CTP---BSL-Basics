using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindColliders : MonoBehaviour
{
    public Collider RightThumbTip;
    public Collider RightThumbMid;
    public Collider RightThumbBot;

    public Collider RightIndexTip;
    public Collider RightIndexMid;
    public Collider RightIndexBot;

    public Collider RightMiddleTip;
    public Collider RightMiddleMid;
    public Collider RightMiddleBot;

    public Collider RightRingTip;
    public Collider RightRingMid;
    public Collider RightRingBot;

    public Collider RightPinkyTip;
    public Collider RightPinkyMid;
    public Collider RightPinkyBot;

    public Collider RightOpen;
    public Collider RightClosed;

    public Collider LeftThumbTip;
    public Collider LeftThumbMid;
    public Collider LeftThumbBot;

    public Collider LeftIndexTip;
    public Collider LeftIndexMid;
    public Collider LeftIndexBot;

    public Collider LeftMiddleTip;
    public Collider LeftMiddleMid;
    public Collider LeftMiddleBot;

    public Collider LeftRingTip;
    public Collider LeftRingMid;
    public Collider LeftRingBot;

    public Collider LeftPinkyTip;
    public Collider LeftPinkyMid;
    public Collider LeftPinkyBot;

    public Collider LeftThumbCreaseFront;

    // - MAY NEED TO BE ALTERED
    public Collider LeftIndexPalm;
    public Collider LeftPinkyPalm;
    public Collider TouchpointZ;
    //

    public Collider LeftOpen;
    public Collider LeftClosed;

    // Use this for initialization
    void Start ()
    {
        FindLeftColliders();
        FindRightColliders();
    }

    private void FindRightColliders()
    {
        RightThumb();
        RightIndex();
        RightMiddle();
        RightRing();
        RightPinky();

        RightOther();
    }

    private void RightThumb()
    {
        RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();
        RightThumbMid = GameObject.FindGameObjectWithTag("RightThumbMid").GetComponent<CapsuleCollider>();
        RightThumbBot = GameObject.FindGameObjectWithTag("RightThumbBot").GetComponent<CapsuleCollider>();
    }

    private void RightIndex()
    {
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightIndexMid = GameObject.FindGameObjectWithTag("RightIndexMid").GetComponent<CapsuleCollider>();
        RightIndexBot = GameObject.FindGameObjectWithTag("RightIndexBot").GetComponent<CapsuleCollider>();
    }

    private void RightMiddle()
    {
        RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
        RightMiddleMid = GameObject.FindGameObjectWithTag("RightMiddleMid").GetComponent<CapsuleCollider>();
        RightMiddleBot = GameObject.FindGameObjectWithTag("RightMiddleBot").GetComponent<CapsuleCollider>();
    }

    private void RightRing()
    {
        RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();
        RightRingMid = GameObject.FindGameObjectWithTag("RightRingMid").GetComponent<CapsuleCollider>();
        RightRingBot = GameObject.FindGameObjectWithTag("RightRingBot").GetComponent<CapsuleCollider>();
    }

    private void RightPinky()
    {
        RightPinkyTip = GameObject.FindGameObjectWithTag("RightPinkyTip").GetComponent<CapsuleCollider>();
        RightPinkyMid = GameObject.FindGameObjectWithTag("RightPinkyMid").GetComponent<CapsuleCollider>();
        RightPinkyBot = GameObject.FindGameObjectWithTag("RightPinkyBot").GetComponent<CapsuleCollider>();
    }

    private void RightOther()
    {
        //RightOpen = GameObject.FindGameObjectWithTag("").GetComponent<CapsuleCollider>();
        RightClosed = GameObject.FindGameObjectWithTag("ClosedFingersRight").GetComponent<BoxCollider>();
    }

    private void FindLeftColliders()
    {
        LeftThumb();
        LeftIndex();
        LeftMiddle();
        LeftRing();
        LeftPinky();

        LeftOther();
    }

    private void LeftThumb()
    {
        LeftThumbTip = GameObject.FindGameObjectWithTag("LeftThumbTip").GetComponent<CapsuleCollider>();
        LeftThumbMid = GameObject.FindGameObjectWithTag("LeftThumbMid").GetComponent<CapsuleCollider>();
        LeftThumbBot = GameObject.FindGameObjectWithTag("LeftThumbBot").GetComponent<CapsuleCollider>();
    }

    private void LeftIndex()
    {
        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        LeftIndexMid = GameObject.FindGameObjectWithTag("LeftIndexMid").GetComponent<CapsuleCollider>();
        LeftIndexBot = GameObject.FindGameObjectWithTag("LeftIndexBot").GetComponent<CapsuleCollider>();
    }

    private void LeftMiddle()
    {
        LeftMiddleTip = GameObject.FindGameObjectWithTag("LeftMiddleTip").GetComponent<CapsuleCollider>();
        LeftMiddleMid = GameObject.FindGameObjectWithTag("LeftMiddleMid").GetComponent<CapsuleCollider>();
        LeftMiddleBot = GameObject.FindGameObjectWithTag("LeftMiddleBot").GetComponent<CapsuleCollider>();
    }

    private void LeftRing()
    {
        LeftRingTip = GameObject.FindGameObjectWithTag("LeftRingTip").GetComponent<CapsuleCollider>();
        LeftRingMid = GameObject.FindGameObjectWithTag("LeftRingMid").GetComponent<CapsuleCollider>();
        LeftRingBot = GameObject.FindGameObjectWithTag("LeftRingBot").GetComponent<CapsuleCollider>();
    }

    private void LeftPinky()
    {
        LeftPinkyTip = GameObject.FindGameObjectWithTag("LeftPinkyTip").GetComponent<CapsuleCollider>();
        LeftPinkyMid = GameObject.FindGameObjectWithTag("LeftPinkyMid").GetComponent<CapsuleCollider>();
        LeftPinkyBot = GameObject.FindGameObjectWithTag("LeftPinkyBot").GetComponent<CapsuleCollider>();
    }

    private void LeftOther()
    {
        LeftThumbCreaseFront = GameObject.FindGameObjectWithTag("LeftThumbCreaseFront").GetComponent<CapsuleCollider>();

        // CHANGE??
        LeftIndexPalm = GameObject.FindGameObjectWithTag("LeftIndexPalm").GetComponent<BoxCollider>();
        LeftPinkyPalm = GameObject.FindGameObjectWithTag("LeftPinkyPalm").GetComponent<BoxCollider>();
        TouchpointZ = GameObject.FindGameObjectWithTag("TouchpointZ").GetComponent<BoxCollider>();
        //

        //LeftOpen = GameObject.FindGameObjectWithTag("").GetComponent<CapsuleCollider>();
        LeftClosed = GameObject.FindGameObjectWithTag("ClosedFingersLeft").GetComponent<BoxCollider>();
    }
}
