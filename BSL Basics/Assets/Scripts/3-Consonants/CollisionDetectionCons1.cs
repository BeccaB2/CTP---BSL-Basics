using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCons1 : MonoBehaviour
{
    GameObject leftHand;
    GameObject rightHand;

    Collider RightThumbTip;
    Collider RightIndexTip;
    Collider RightMiddleTip;

    Collider LeftThumbTip;
    Collider LeftIndexTip;
    Collider LeftIndexBot;
    Collider LeftMiddleMid;
    Collider LeftMiddleBot;

    public bool BSigned;
    public bool CSigned;
    public bool DSigned;
    public bool FSigned;

    public bool BPracticed;
    public bool CPracticed;
    public bool DPracticed;
    public bool FPracticed;

    void Start ()
    {
        BSigned = false;
        CSigned = false;
        DSigned = false;
        FSigned = false;

        BPracticed = false;
        CPracticed = false;
        DPracticed = false;
        FPracticed = false;

        FindHands();
        FindLeftColliders();
        FindRightColliders();
    }

    void Update ()
    {
        CheckCollision();
    }

    private void FindHands()
    {
        leftHand = GameObject.Find("RigidRoundHand_L");
        rightHand = GameObject.Find("RigidRoundHand_R");
    }

    private void FindRightColliders()
    {
        RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {
        LeftThumbTip = GameObject.FindGameObjectWithTag("LeftThumbTip").GetComponent<CapsuleCollider>();
        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        LeftIndexBot = GameObject.FindGameObjectWithTag("LeftIndexBot").GetComponent<CapsuleCollider>();
        LeftMiddleBot = GameObject.FindGameObjectWithTag("LeftMiddleBot").GetComponent<CapsuleCollider>();
        LeftMiddleMid = GameObject.FindGameObjectWithTag("LeftMiddleMid").GetComponent<CapsuleCollider>();
    }

    private void CheckCollision()
    {
        // B - Janky
        if (LeftIndexTip.bounds.Intersects(RightIndexTip.bounds) &&
            LeftThumbTip.bounds.Intersects(RightThumbTip.bounds) &&
            LeftIndexTip.bounds.Intersects(LeftThumbTip.bounds) &&
            RightIndexTip.bounds.Intersects(RightThumbTip.bounds))
        {
            Debug.Log("B");
            BSigned = true;
            BPracticed = true;
        }
        else
        {
            BSigned = false;
        }

        // C - Checking distance between thumb and index on right hand (ALWAYS RECOGINISED ATM)
        float rightThumbAndIndexDistanceC = Vector3.Distance(RightIndexTip.transform.position, RightThumbTip.transform.position);

        if (rightThumbAndIndexDistanceC > 0.04 && rightThumbAndIndexDistanceC < 0.07 && 
            rightHand.activeInHierarchy == true && 
            leftHand.activeInHierarchy == false)
        {
            Debug.Log("C");
            CSigned = true;
            CPracticed = true;
        }
        else
        {
            CSigned = false;
        }

        // D - Janky
        if (RightIndexTip.bounds.Intersects(LeftIndexTip.bounds) &&
            RightThumbTip.bounds.Intersects(LeftIndexBot.bounds))
        {
            Debug.Log("D");
            DSigned = true;
            DPracticed = true;
        }
        else
        {
            DSigned = false;
        }

        // F - Janky
        if (RightIndexTip.bounds.Intersects(LeftMiddleBot.bounds) &&
            RightMiddleTip.bounds.Intersects(LeftMiddleMid.bounds))
        {
            Debug.Log("F");
            FSigned = true;
            FPracticed = true;
        }
        else
        {
            FSigned = false;
        }
    }
}
