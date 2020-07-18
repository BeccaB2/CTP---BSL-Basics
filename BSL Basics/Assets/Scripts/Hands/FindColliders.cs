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

    public GameObject hands;
    public GameObject left;
    public GameObject right;

    public GameObject leftThumb;
    public GameObject leftIndex;
    public GameObject leftMid;
    public GameObject leftRing;
    public GameObject leftPinky;

    public GameObject rightThumb;
    public GameObject rightIndex;
    public GameObject rightMid;
    public GameObject rightRing;
    public GameObject rightPinky;

    // Use this for initialization
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "MountedHandDemo" ||
            SceneManager.GetActiveScene().name == "VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }

        left = hands.transform.Find("RigidRoundHand_L").gameObject;
        right = hands.transform.Find("RigidRoundHand_R").gameObject;

        leftThumb = left.transform.Find("thumb").gameObject;
        leftIndex = left.transform.Find("index").gameObject;
        leftMid = left.transform.Find("middle").gameObject;
        leftRing = left.transform.Find("ring").gameObject;
        leftPinky = left.transform.Find("pinky").gameObject;

        rightThumb = right.transform.Find("thumb").gameObject;
        rightIndex = right.transform.Find("index").gameObject;
        rightMid = right.transform.Find("middle").gameObject;
        rightRing = right.transform.Find("ring").gameObject;
        rightPinky = right.transform.Find("pinky").gameObject;

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
        RightThumbTip = rightThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();
        RightThumbMid = rightThumb.transform.Find("bone2").GetComponent<CapsuleCollider>();
        RightThumbBot = rightThumb.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //RightThumbTip = this.transform.Find("RightThumbTip").GetComponent<CapsuleCollider>();
        //RightThumbTip = hands.transform.Find("RightThumbTip").GetComponent<CapsuleCollider>();
        //RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();

        //RightThumbMid = GameObject.FindGameObjectWithTag("RightThumbMid").GetComponent<CapsuleCollider>();
        //RightThumbBot = GameObject.FindGameObjectWithTag("RightThumbBot").GetComponent<CapsuleCollider>();
    }

    private void RightIndex()
    {
        RightIndexTip = rightIndex.transform.Find("bone3").GetComponent<CapsuleCollider>();
        RightIndexMid = rightIndex.transform.Find("bone2").GetComponent<CapsuleCollider>();
        RightIndexBot = rightIndex.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        //RightIndexMid = GameObject.FindGameObjectWithTag("RightIndexMid").GetComponent<CapsuleCollider>();
        //RightIndexBot = GameObject.FindGameObjectWithTag("RightIndexBot").GetComponent<CapsuleCollider>();
    }

    private void RightMiddle()
    {
        RightMiddleTip = rightMid.transform.Find("bone3").GetComponent<CapsuleCollider>();
        RightMiddleMid = rightMid.transform.Find("bone2").GetComponent<CapsuleCollider>();
        RightMiddleBot = rightMid.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
        //RightMiddleMid = GameObject.FindGameObjectWithTag("RightMiddleMid").GetComponent<CapsuleCollider>();
        //RightMiddleBot = GameObject.FindGameObjectWithTag("RightMiddleBot").GetComponent<CapsuleCollider>();
    }

    private void RightRing()
    {
        RightRingTip = rightRing.transform.Find("bone3").GetComponent<CapsuleCollider>();
        RightRingMid = rightRing.transform.Find("bone2").GetComponent<CapsuleCollider>();
        RightRingBot = rightRing.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();
        //RightRingMid = GameObject.FindGameObjectWithTag("RightRingMid").GetComponent<CapsuleCollider>();
        //RightRingBot = GameObject.FindGameObjectWithTag("RightRingBot").GetComponent<CapsuleCollider>();
    }

    private void RightPinky()
    {
        RightPinkyTip = rightPinky.transform.Find("bone3").GetComponent<CapsuleCollider>();
        RightPinkyMid = rightPinky.transform.Find("bone2").GetComponent<CapsuleCollider>();
        RightPinkyBot = rightPinky.transform.Find("bone1").GetComponent<CapsuleCollider>();

        //RightPinkyTip = GameObject.FindGameObjectWithTag("RightPinkyTip").GetComponent<CapsuleCollider>();
        //RightPinkyMid = GameObject.FindGameObjectWithTag("RightPinkyMid").GetComponent<CapsuleCollider>();
        //RightPinkyBot = GameObject.FindGameObjectWithTag("RightPinkyBot").GetComponent<CapsuleCollider>();
    }

    private void RightOther()
    {
        //RightOpen = GameObject.FindGameObjectWithTag("").GetComponent<CapsuleCollider>();

        RightIndexKnuckle = rightIndex.transform.Find("IndexKnuckle").GetComponent<CapsuleCollider>();
        RightMiddleKnuckle = rightMid.transform.Find("MidKnuckle").GetComponent<CapsuleCollider>();
        RightRingKnuckle = rightRing.transform.Find("RingKnuckle").GetComponent<CapsuleCollider>();
        RightPinkyKnuckle = rightPinky.transform.Find("PinkyKnuckle").GetComponent<CapsuleCollider>();

        //RightIndexKnuckle = GameObject.FindGameObjectWithTag("RightIndexKnuckle").GetComponent<CapsuleCollider>();
        //RightMiddleKnuckle = GameObject.FindGameObjectWithTag("RightMiddleKnuckle").GetComponent<CapsuleCollider>();
        //RightRingKnuckle = GameObject.FindGameObjectWithTag("RightRingKnuckle").GetComponent<CapsuleCollider>();
        //RightPinkyKnuckle = GameObject.FindGameObjectWithTag("RightPinkyKnuckle").GetComponent<CapsuleCollider>();

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
        //LeftThumbTip = hands.transform.Find("LeftThumbTip").GetComponent<CapsuleCollider>();
        //LeftThumbTip = this.transform.Find("LeftThumbTip").GetComponent<CapsuleCollider>();
        //LeftThumbTip = hands.transform.Find("LeftThumbTip").GetComponent<CapsuleCollider>();

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

        LeftIndexKnuckle = GameObject.FindGameObjectWithTag("LeftIndexKnuckle").GetComponent<CapsuleCollider>();
        LeftMiddleKnuckle = GameObject.FindGameObjectWithTag("LeftMiddleKnuckle").GetComponent<CapsuleCollider>();
        LeftRingKnuckle = GameObject.FindGameObjectWithTag("LeftRingKnuckle").GetComponent<CapsuleCollider>();
        LeftPinkyKnuckle = GameObject.FindGameObjectWithTag("LeftPinkyKnuckle").GetComponent<CapsuleCollider>();

        //LeftOpen = GameObject.FindGameObjectWithTag("").GetComponent<CapsuleCollider>();
        LeftClosed = GameObject.FindGameObjectWithTag("ClosedFingersLeft").GetComponent<BoxCollider>();

        // Vowels
        VowelA = leftThumb.transform.Find("ThumbTip").GetComponent<CapsuleCollider>();
        VowelE = GameObject.FindGameObjectWithTag("ETip").GetComponent<CapsuleCollider>();
        VowelI = GameObject.FindGameObjectWithTag("ITip").GetComponent<CapsuleCollider>();
        VowelO = GameObject.FindGameObjectWithTag("OTip").GetComponent<CapsuleCollider>();
        VowelU = GameObject.FindGameObjectWithTag("UTip").GetComponent<CapsuleCollider>();

        //RightThumbTip = rightThumb.transform.Find("bone3").GetComponent<CapsuleCollider>();

    }
}