using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionCons2 : MonoBehaviour
{
    Collider LeftThumbBot;
    Collider LeftIndexMiddle;
    Collider LeftMiddleTip;

    Collider LeftThumbPalm;

    Collider RightIndexTip;
    Collider RightIndexMiddle;
    Collider RightMiddleTip;
    Collider RightPinkyTip;

    public bool GSigned;
    public bool HSigned;
    public bool JSigned;
    public bool KSigned;

    public bool GPracticed;
    public bool HPracticed;
    public bool JPracticed;
    public bool KPracticed;

    bool HStartPosition;
    bool HEndPosition;

    bool JStartPosition;
    bool JEndPosition;

    void Start()
    {
        InitBools();

        FindLeftColliders();
        FindRightColliders();
    }

    void Update()
    {
        CheckCollision();
    }

    private void InitBools()
    {
        GSigned = false;
        HSigned = false;
        JSigned = false;
        KSigned = false;

        GPracticed = false;
        HPracticed = false;
        JPracticed = false;
        KPracticed = false;

        HStartPosition = false;
        HEndPosition = false;

        JStartPosition = false;
        JEndPosition = false;
    }

    private void FindRightColliders()
    {
        RightIndexTip = GameObject.FindGameObjectWithTag("RightIndexTip").GetComponent<CapsuleCollider>();
        RightIndexMiddle = GameObject.FindGameObjectWithTag("RightIndexMid").GetComponent<CapsuleCollider>();
        RightMiddleTip = GameObject.FindGameObjectWithTag("RightMiddleTip").GetComponent<CapsuleCollider>();
        RightPinkyTip = GameObject.FindGameObjectWithTag("RightPinkyTip").GetComponent<CapsuleCollider>();
    }

    private void FindLeftColliders()
    {
        LeftThumbBot = GameObject.FindGameObjectWithTag("LeftThumbBot").GetComponent<CapsuleCollider>();
        LeftIndexMiddle = GameObject.FindGameObjectWithTag("LeftIndexMid").GetComponent<CapsuleCollider>();
        LeftMiddleTip = GameObject.FindGameObjectWithTag("LeftMiddleTip").GetComponent<CapsuleCollider>();

        LeftThumbPalm = GameObject.FindGameObjectWithTag("LeftThumbPalm").GetComponent<CapsuleCollider>();
    }

    private void CheckCollision()
    {
        // G
        // Checking distance between the pinky and the thumb of both hands
        float pinkyAndThumbDistanceG = Vector3.Distance(RightPinkyTip.transform.position, LeftThumbBot.transform.position);

        //Maybe add colliders to each hand to check if fingers are closed???
        if (pinkyAndThumbDistanceG > 0.03 && pinkyAndThumbDistanceG < 0.04) 
        {
            Debug.Log("G");
            GSigned = true;
            GPracticed = true;
        }
        else
        {
            GSigned = false;
        }

        // H - Will only run if the user is not in process of signing J
        if(JStartPosition == false && JEndPosition == false)
        {
            // Checking to see if the start position is performed - resets if the end action isn't performed within a timeframe
            if (RightIndexTip.bounds.Intersects(LeftThumbPalm.bounds))
            {
                HStartPosition = true;
                StartCoroutine(ResetStartPosH());
            }

            // Checking for the end position of fingers
            if (HStartPosition == true && HEndPosition == false)
            {
                StartCoroutine(CheckForEndPosH());
            }

            if (HEndPosition == true && HStartPosition == true)
            {
                Debug.Log("H");
                HSigned = true;
                HPracticed = true;

                StartCoroutine(ResetH());
            }
            else
            {
                HSigned = false;
            }
        }

        // J - will only run if H is not in process of being signed
        if (HStartPosition == false && HEndPosition == false)
        {
            if (RightIndexTip.bounds.Intersects(LeftMiddleTip.bounds))
            {
                JStartPosition = true;
                StartCoroutine(ResetStartPosJ());
            }

            if (JStartPosition == true && JEndPosition == false)
            {
                StartCoroutine(CheckForEndPosJ());
            }

            if (JEndPosition == true && JEndPosition == true)
            {
                Debug.Log("J");
                JSigned = true;
                JPracticed = true;

                StartCoroutine(ResetJ());
            }
            else
            {
                JSigned = false;
            }
        }

        // K
        if (RightIndexMiddle.bounds.Intersects(LeftIndexMiddle.bounds))
        {
            Debug.Log("K");
            KSigned = true;
            KPracticed = true;
        }
        else
        {
            KSigned = false;
        }
    }

    IEnumerator CheckForEndPosH()
    {
        //Debug.Log("REACHED");

        // Checking if the end position is reached
        while (HEndPosition == false && HStartPosition == true)
        {
            if (RightMiddleTip.bounds.Intersects(LeftMiddleTip.bounds))
            {
                HEndPosition = true;
            }

            yield return null;
        }
    }

    IEnumerator CheckForEndPosJ()
    {
        while(JEndPosition == false && JStartPosition == true)
        {
            if (RightIndexTip.bounds.Intersects(LeftThumbPalm.bounds))
            {
                JEndPosition = true;
            }

            yield return null;
        }    
    }

    IEnumerator ResetH()
    {
        // Resetting values after the sign has been performed - delay to avoid J being recognised straight away
        yield return new WaitForSeconds(2);
        HEndPosition = false;
        HStartPosition = false;
    }

    IEnumerator ResetJ()
    {
        yield return new WaitForSeconds(2);
        JEndPosition = false;
        JStartPosition = false;
    }

    IEnumerator ResetStartPosH()
    {
        while(HStartPosition == true)
        {
            yield return new WaitForSeconds(5);
            HStartPosition = false;
        }
    }

    IEnumerator ResetStartPosJ()
    {
        while (JStartPosition == true)
        {
            yield return new WaitForSeconds(5);
            JStartPosition = false;
        }
    }
}

    // TEST CLOSED FINGERS!!!
