using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionVowels : MonoBehaviour
{
    Collider RightIndexTip;

    Collider LeftThumbTip;
    Collider LeftIndexTip;
    Collider LeftMiddleTip;
    Collider LeftRingTip;
    Collider LeftPinkyTip;

    public bool ASigned;
    public bool ESigned;
    public bool ISigned;
    public bool OSigned;
    public bool USigned;

    public bool APracticed;
    public bool EPracticed;
    public bool IPracticed;
    public bool OPracticed;
    public bool UPracticed;

    void Start()
    {
        ASigned = false;
        ESigned = false;
        ISigned = false;
        OSigned = false;
        USigned = false;

        APracticed = false;
        EPracticed = false;
        IPracticed = false;
        OPracticed = false;
        UPracticed = false;
        
        // Finds & assigns colliders to gameobject when in view - can also assign in the inspector
        FindLeftColliders();
        FindRightColliders();
    }

    void Update()
    {
        // Checks what fingers are touching
        CheckCollision();
    }

    private void FindRightColliders()
    {
        //Debug.Log("RIGHT");
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {
        //Debug.Log("LEFT");
        LeftThumbTip = GameObject.FindGameObjectWithTag("LeftThumbTip").GetComponent<CapsuleCollider>();
        LeftIndexTip = GameObject.FindGameObjectWithTag("LeftIndexTip").GetComponent<CapsuleCollider>();
        LeftMiddleTip = GameObject.FindGameObjectWithTag("LeftMiddleTip").GetComponent<CapsuleCollider>();
        LeftRingTip = GameObject.FindGameObjectWithTag("LeftRingTip").GetComponent<CapsuleCollider>();
        LeftPinkyTip = GameObject.FindGameObjectWithTag("LeftPinkyTip").GetComponent<CapsuleCollider>();
    }

    private void CheckCollision()
    {
        // Checks if the two colliders intersect
        // A
        if (RightIndexTip.bounds.Intersects(LeftThumbTip.bounds))
        {
            Debug.Log("A");
            ASigned = true;
            APracticed = true;
        }
        else
        {
            ASigned = false;
        }

        // E
        if (RightIndexTip.bounds.Intersects(LeftIndexTip.bounds))
        {
            Debug.Log("E");         
            ESigned = true;
            EPracticed = true;
        }
        else
        {
            ESigned = false;
        }

        // I
        if (RightIndexTip.bounds.Intersects(LeftMiddleTip.bounds))
        {
            Debug.Log("I");
            ISigned = true;
            IPracticed = true;
        }
        else
        {
            ISigned = false;
        }

        // O 
        if (RightIndexTip.bounds.Intersects(LeftRingTip.bounds))
        {
            Debug.Log("O");
            OSigned = true;
            OPracticed = true;
        }
        else
        {
            OSigned = false;
        }

        // U
        if (RightIndexTip.bounds.Intersects(LeftPinkyTip.bounds))
        {
            Debug.Log("U");
            USigned = true;
            UPracticed = true;
        }
        else
        {
            USigned = false;
        }
    }
}
