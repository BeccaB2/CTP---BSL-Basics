using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCons3 : MonoBehaviour
{
    Collider RightThumbTip;
    Collider RightIndexTip;
    Collider RightMiddleTip;
    Collider RightRingTip;

    Collider LeftIndexTip;
    Collider LeftIndexPalm;

    public bool LSigned;
    public bool MSigned;
    public bool NSigned;
    public bool PSigned;

    public bool LPracticed;
    public bool MPracticed;
    public bool NPracticed;
    public bool PPracticed;

    void Start()
    {
        LSigned = false;
        MSigned = false;
        NSigned = false;
        PSigned = false;

        LPracticed = false;
        MPracticed = false;
        NPracticed = false;
        PPracticed = false;

        FindLeftColliders();
        FindRightColliders();
    }

    void Update()
    {
        CheckCollision();
    }

    private void FindRightColliders()
    {
        RightThumbTip = GameObject.FindGameObjectWithTag("RightThumbTip").GetComponent<CapsuleCollider>();
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
        RightRingTip = GameObject.FindGameObjectWithTag("RightRingTip").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {
        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        LeftIndexPalm = GameObject.FindGameObjectWithTag("LeftIndexPalm").GetComponent<BoxCollider>();
    }

    private void CheckCollision()
    {
        // L
        if (RightIndexTip.bounds.Intersects(LeftIndexPalm.bounds))
        {
            Debug.Log("L");
            LSigned = true;
            LPracticed = true;
        }
        else
        {
            LSigned = false;
        }

        // M
        if (RightIndexTip.bounds.Intersects(LeftIndexPalm.bounds) &&
            RightMiddleTip.bounds.Intersects(LeftIndexPalm.bounds) &&
            RightRingTip.bounds.Intersects(LeftIndexPalm.bounds))
        {
            Debug.Log("M");
            MSigned = true;
            MPracticed = true;
        }
        else
        {
            MSigned = false;
        }

        // N
        if (RightIndexTip.bounds.Intersects(LeftIndexPalm.bounds) &&
            RightMiddleTip.bounds.Intersects(LeftIndexPalm.bounds))
        {
            Debug.Log("N");
            NSigned = true;
            NPracticed = true;
        }
        else
        {
            NSigned = false;
        }

        // P
        if (RightIndexTip.bounds.Intersects(RightThumbTip.bounds) &&
            RightIndexTip.bounds.Intersects(LeftIndexTip.bounds) &&
            RightThumbTip.bounds.Intersects(LeftIndexTip.bounds))
        {
            Debug.Log("P");
            PSigned = true;
            PPracticed = true;
        }
        else
        {
            PSigned = false;
        }
    }
}
