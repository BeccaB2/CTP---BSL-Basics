using Leap.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public Collider RightIndexKnuckle;
    public Collider RightMiddleKnuckle;
    public Collider RightRingKnuckle;
    public Collider RightPinkyKnuckle;

    //public Collider RightOpen;
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

    public Collider LeftIndexKnuckle;
    public Collider LeftMiddleKnuckle;
    public Collider LeftRingKnuckle;
    public Collider LeftPinkyKnuckle;

    public Collider VowelA;
    public Collider VowelE;
    public Collider VowelI;
    public Collider VowelO;
    public Collider VowelU;

    //public Collider LeftOpen;
    public Collider LeftClosed;

    //GameObject hands;
    //GameObject left;
    //GameObject right;

    //GameObject leftThumb;
    //GameObject leftIndex;
    //GameObject leftMid;
    //GameObject leftRing;
    //GameObject leftPinky;
    //GameObject leftPalm;

    //GameObject rightThumb;
    //GameObject rightIndex;
    //GameObject rightMid;
    //GameObject rightRing;
    //GameObject rightPinky;
    //GameObject rightPalm;

    // Use this for initialization
    void Start()
    {
        //if (SceneManager.GetActiveScene().name == "MountedHandDemo" ||
        //    SceneManager.GetActiveScene().name == "VowelPracticeVR")
        //{
        //    hands = GameObject.Find("LeapHandController");
        //}
        //else
        //{
        //    hands = GameObject.Find("HandModels");
        //}

        // Maybe change below to similar??
        //hands = GameObject.Find("LeapHandController");
        //right = hands.transform.Find("RigidRoundHand_R");

        //left = GameObject.Find("RigidRoundHand_L");
        //right = GameObject.Find("RigidRoundHand_R");

        //leftThumb = GameObject.Find("thumb");
        //leftIndex = GameObject.Find("index");
        //leftMid = GameObject.Find("middle");
        //leftRing = GameObject.Find("ring");
        //leftPinky = GameObject.Find("pinky");
        //leftPalm = GameObject.Find("palm");

        //rightThumb = GameObject.Find("thumb");
        //rightIndex = GameObject.Find("index");
        //rightMid = GameObject.Find("middle");
        //rightRing = GameObject.Find("ring");
        //rightPinky = GameObject.Find("pinky");
        //rightPalm = GameObject.Find("palm");

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
        //RightThumbTip = rightThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //RightThumbMid = rightThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //RightThumbBot = rightThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //RightThumbTip = this.transform.Find("RightThumbTip").GetComponent<CapsuleCollider>();
        //RightThumbTip = hands.transform.Find("RightThumbTip").GetComponent<CapsuleCollider>();

        RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();
        RightThumbMid = GameObject.FindGameObjectWithTag("RightThumbMid").GetComponent<CapsuleCollider>();
        RightThumbBot = GameObject.FindGameObjectWithTag("RightThumbBot").GetComponent<CapsuleCollider>();
    }

    private void RightIndex()
    {
        //RightIndexTip = rightIndex.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //RightIndexMid = rightIndex.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //RightIndexBot = rightIndex.transform.Find("bone1").GetComponent<CapsuleCollider>();

        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightIndexMid = GameObject.FindGameObjectWithTag("RightIndexMid").GetComponent<CapsuleCollider>();
        RightIndexBot = GameObject.FindGameObjectWithTag("RightIndexBot").GetComponent<CapsuleCollider>();
    }

    private void RightMiddle()
    {
        //RightMiddleTip = rightMid.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //RightMiddleMid = rightMid.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //RightMiddleBot = rightMid.transform.Find("bone1").GetComponent<CapsuleCollider>();

        RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
        RightMiddleMid = GameObject.FindGameObjectWithTag("RightMiddleMid").GetComponent<CapsuleCollider>();
        RightMiddleBot = GameObject.FindGameObjectWithTag("RightMiddleBot").GetComponent<CapsuleCollider>();
    }

    private void RightRing()
    {
        //RightRingTip = rightRing.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //RightRingMid = rightRing.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //RightRingBot = rightRing.transform.Find("bone1").GetComponent<CapsuleCollider>();

        RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();
        RightRingMid = GameObject.FindGameObjectWithTag("RightRingMid").GetComponent<CapsuleCollider>();
        RightRingBot = GameObject.FindGameObjectWithTag("RightRingBot").GetComponent<CapsuleCollider>();
    }

    private void RightPinky()
    {
        //RightPinkyTip = rightPinky.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //RightPinkyMid = rightPinky.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //RightPinkyBot = rightPinky.transform.Find("bone1").GetComponent<CapsuleCollider>();

        RightPinkyTip = GameObject.FindGameObjectWithTag("RightPinkyTip").GetComponent<CapsuleCollider>();
        RightPinkyMid = GameObject.FindGameObjectWithTag("RightPinkyMid").GetComponent<CapsuleCollider>();
        RightPinkyBot = GameObject.FindGameObjectWithTag("RightPinkyBot").GetComponent<CapsuleCollider>();
    }

    private void RightOther()
    {
        //RightIndexKnuckle = rightIndex.transform.Find("IndexKnuckle").GetComponent<CapsuleCollider>();
        //RightMiddleKnuckle = rightMid.transform.Find("MidKnuckle").GetComponent<CapsuleCollider>();
        //RightRingKnuckle = rightRing.transform.Find("RingKnuckle").GetComponent<CapsuleCollider>();
        //RightPinkyKnuckle = rightPinky.transform.Find("PinkyKnuckle").GetComponent<CapsuleCollider>();

        //RightClosed = rightPalm.transform.Find("ClosedFingersRight").GetComponent<BoxCollider>();

        RightIndexKnuckle = GameObject.FindGameObjectWithTag("RightIndexKnuckle").GetComponent<CapsuleCollider>();
        RightMiddleKnuckle = GameObject.FindGameObjectWithTag("RightMiddleKnuckle").GetComponent<CapsuleCollider>();
        RightRingKnuckle = GameObject.FindGameObjectWithTag("RightRingKnuckle").GetComponent<CapsuleCollider>();
        RightPinkyKnuckle = GameObject.FindGameObjectWithTag("RightPinkyKnuckle").GetComponent<CapsuleCollider>();

        RightClosed = GameObject.FindGameObjectWithTag("ClosedFingersRight").GetComponent<BoxCollider>();
        //RightOpen = GameObject.FindGameObjectWithTag("").GetComponent<CapsuleCollider>();
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
        //LeftThumbTip = leftThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //LeftThumbMid = leftThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //LeftThumbBot = leftThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //LeftThumbTip = hands.transform.Find("LeftThumbTip").GetComponent<CapsuleCollider>();
        //LeftThumbTip = this.transform.Find("LeftThumbTip").GetComponent<CapsuleCollider>();

        LeftThumbTip = GameObject.FindGameObjectWithTag("LeftThumbTip").GetComponent<CapsuleCollider>();
        LeftThumbMid = GameObject.FindGameObjectWithTag("LeftThumbMid").GetComponent<CapsuleCollider>();
        LeftThumbBot = GameObject.FindGameObjectWithTag("LeftThumbBot").GetComponent<CapsuleCollider>();
    }

    private void LeftIndex()
    {
        //LeftIndexTip = leftThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //LeftIndexMid = leftThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //LeftIndexBot = leftThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        LeftIndexMid = GameObject.FindGameObjectWithTag("LeftIndexMid").GetComponent<CapsuleCollider>();
        LeftIndexBot = GameObject.FindGameObjectWithTag("LeftIndexBot").GetComponent<CapsuleCollider>();
    }

    private void LeftMiddle()
    {
        //LeftMiddleTip = leftThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //LeftMiddleMid = leftThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //LeftMiddleBot = leftThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        LeftMiddleTip = GameObject.FindGameObjectWithTag("LeftMiddleTip").GetComponent<CapsuleCollider>();
        LeftMiddleMid = GameObject.FindGameObjectWithTag("LeftMiddleMid").GetComponent<CapsuleCollider>();
        LeftMiddleBot = GameObject.FindGameObjectWithTag("LeftMiddleBot").GetComponent<CapsuleCollider>();
    }

    private void LeftRing()
    {
        //LeftRingTip = leftThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //LeftRingMid = leftThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //LeftRingBot = leftThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        LeftRingTip = GameObject.FindGameObjectWithTag("LeftRingTip").GetComponent<CapsuleCollider>();
        LeftRingMid = GameObject.FindGameObjectWithTag("LeftRingMid").GetComponent<CapsuleCollider>();
        LeftRingBot = GameObject.FindGameObjectWithTag("LeftRingBot").GetComponent<CapsuleCollider>();
    }

    private void LeftPinky()
    {
        //LeftPinkyTip = leftThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        //LeftPinkyMid = leftThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        //LeftPinkyBot = leftThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        LeftPinkyTip = GameObject.FindGameObjectWithTag("LeftPinkyTip").GetComponent<CapsuleCollider>();
        LeftPinkyMid = GameObject.FindGameObjectWithTag("LeftPinkyMid").GetComponent<CapsuleCollider>();
        LeftPinkyBot = GameObject.FindGameObjectWithTag("LeftPinkyBot").GetComponent<CapsuleCollider>();
    }

    private void LeftOther()
    {
        //LeftIndexKnuckle = leftIndex.transform.Find("IndexKnuckle").GetComponent<CapsuleCollider>();
        //LeftMiddleKnuckle = leftMid.transform.Find("MidKnuckle").GetComponent<CapsuleCollider>();
        //LeftRingKnuckle = leftRing.transform.Find("RingKnuckle").GetComponent<CapsuleCollider>();
        //LeftPinkyKnuckle = leftPinky.transform.Find("PinkyKnuckle").GetComponent<CapsuleCollider>();

        //LeftThumbCreaseFront = leftPalm.transform.Find("ThumbPalm").GetComponent<CapsuleCollider>();
        //LeftClosed = leftPalm.transform.Find("ClosedFingersLeft").GetComponent<BoxCollider>();
        //LeftOpen = leftPalm.transform.Find("").GetComponent<BoxCollider>();

        // CHANGE?
        //LeftIndexPalm = leftPalm.transform.Find("IndexPalm").GetComponent<BoxCollider>();
        //LeftPinkyPalm = leftPalm.transform.Find("PinkyPalm").GetComponent<BoxCollider>();
        //TouchpointZ = leftPalm.transform.Find("TouchPointZ").GetComponent<BoxCollider>();

        // Vowels
        //VowelA = leftThumb.transform.Find("ThumbTip").GetComponent<CapsuleCollider>();
        //VowelE = leftThumb.transform.Find("IndexTip").GetComponent<CapsuleCollider>();
        //VowelI = leftThumb.transform.Find("MiddleTip").GetComponent<CapsuleCollider>();
        //VowelO = leftThumb.transform.Find("RingTip").GetComponent<CapsuleCollider>();
        //VowelU = leftThumb.transform.Find("PinkyTip").GetComponent<CapsuleCollider>();

        // OLD

        LeftThumbCreaseFront = GameObject.FindGameObjectWithTag("LeftThumbCreaseFront").GetComponent<CapsuleCollider>();

        LeftIndexKnuckle = GameObject.FindGameObjectWithTag("LeftIndexKnuckle").GetComponent<CapsuleCollider>();
        LeftMiddleKnuckle = GameObject.FindGameObjectWithTag("LeftMiddleKnuckle").GetComponent<CapsuleCollider>();
        LeftRingKnuckle = GameObject.FindGameObjectWithTag("LeftRingKnuckle").GetComponent<CapsuleCollider>();
        LeftPinkyKnuckle = GameObject.FindGameObjectWithTag("LeftPinkyKnuckle").GetComponent<CapsuleCollider>();

        LeftClosed = GameObject.FindGameObjectWithTag("ClosedFingersLeft").GetComponent<BoxCollider>();
        //LeftOpen = GameObject.FindGameObjectWithTag("").GetComponent<CapsuleCollider>();

        // CHANGE??
        LeftIndexPalm = GameObject.FindGameObjectWithTag("LeftIndexPalm").GetComponent<BoxCollider>();
        LeftPinkyPalm = GameObject.FindGameObjectWithTag("LeftPinkyPalm").GetComponent<BoxCollider>();
        TouchpointZ = GameObject.FindGameObjectWithTag("TouchpointZ").GetComponent<BoxCollider>();

        // Vowels
        VowelA = GameObject.FindGameObjectWithTag("ATip").GetComponent<CapsuleCollider>();
        VowelE = GameObject.FindGameObjectWithTag("ETip").GetComponent<CapsuleCollider>();
        VowelI = GameObject.FindGameObjectWithTag("ITip").GetComponent<CapsuleCollider>();
        VowelO = GameObject.FindGameObjectWithTag("OTip").GetComponent<CapsuleCollider>();
        VowelU = GameObject.FindGameObjectWithTag("UTip").GetComponent<CapsuleCollider>();
    }
}