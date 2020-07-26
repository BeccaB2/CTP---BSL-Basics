using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionCons2 : MonoBehaviour
{
    GameObject hands;
    FindColliders colliders;

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
        // Initialising booleans
        InitBools();

        // Finding hands and colliders
        FindHandsAndColliders();
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

    private void FindHandsAndColliders()
    {
        // Finding the hand object
        if (SceneManager.GetActiveScene().name == "2 - VRHandDemo" ||
            SceneManager.GetActiveScene().name == "1 - VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }

        colliders = hands.GetComponent<FindColliders>();
    }

    void Update()
    {
        CheckCollision();
    }

    private void CheckCollision()
    {
        // G
        // Checking distance between the pinky and the thumb of both hands
        float pinkyAndThumbDistanceG = Vector3.Distance(colliders.RightPinkyTip.transform.position, 
                                                        colliders.LeftThumbBot.transform.position);

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
            if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftThumbCreaseFront.bounds))
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
            if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftMiddleTip.bounds))
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
        if (colliders.RightIndexMid.bounds.Intersects(colliders.LeftIndexMid.bounds))
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
            if (colliders.RightMiddleTip.bounds.Intersects(colliders.LeftMiddleTip.bounds))
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
            if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftThumbCreaseFront.bounds))
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
