using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionCons1 : MonoBehaviour
{
    GameObject leftHand;
    GameObject rightHand;
    GameObject hands;

    FindColliders colliders;
    HandClosureChecking fingers;

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
        // Initialising booleans
        InitBools();

        // Finding hand objects and collider scripts
        FindHandsAndCollisionScripts();
    }

    private void InitBools()
    {
        BSigned = false;
        CSigned = false;
        DSigned = false;
        FSigned = false;

        BPracticed = false;
        CPracticed = false;
        DPracticed = false;
        FPracticed = false;
    }

    private void FindHandsAndCollisionScripts()
    {
        // Finding the overall hand object
        if (SceneManager.GetActiveScene().name == "MountedHandDemo" ||
            SceneManager.GetActiveScene().name == "VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }

        // Colliders for each hand
        colliders = hands.GetComponent<FindColliders>();

        // Finding the hand closure script
        fingers = hands.GetComponent<HandClosureChecking>();

        // Seperate hands
        leftHand = GameObject.Find("RigidRoundHand_L");
        rightHand = GameObject.Find("RigidRoundHand_R");
    }

    void Update()
    {
        CheckCollision();
    }

    private void CheckCollision()
    {
        // B

        //Ray ray = Camera.main.ScreenPointToRay();
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit, 100))
        //    Debug.DrawLine(ray.origin, hit.point);
        //colliders.LeftIndexMid.transform.position
        //Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        Ray ray = new Ray(colliders.LeftIndexKnuckle.transform.position, transform.forward);
        Debug.DrawRay(colliders.LeftIndexKnuckle.transform.position, Vector3.right /*transform.up*/, Color.red);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider == colliders.RightIndexKnuckle)
            {
                //hit.collider.enabled = false;
                Debug.Log("YESS");
            }
        }

        if (colliders.LeftIndexTip.bounds.Intersects(colliders.RightIndexTip.bounds) &&
            colliders.LeftThumbTip.bounds.Intersects(colliders.RightThumbTip.bounds) &&
            colliders.LeftIndexTip.bounds.Intersects(colliders.LeftThumbTip.bounds) &&
            colliders.RightIndexTip.bounds.Intersects(colliders.RightThumbTip.bounds) && 
            fingers.LeftAllClosed == false && fingers.RightAllClosed == false)
        {
            Debug.Log("B");
            BSigned = true;
            BPracticed = true;

            //Debug.DrawLine(colliders.LeftIndexMid.transform.position, colliders.RightIndexMid.transform.position,Color.blue,10);
        }
        else
        {
            BSigned = false;
        }

        // C - Checking distance between thumb and index on right hand (ALWAYS RECOGINISED ATM)
        float rightThumbAndIndexDistanceC = Vector3.Distance(colliders.RightIndexTip.transform.position, colliders.RightThumbTip.transform.position);

        if (rightHand.activeInHierarchy == true && leftHand.activeInHierarchy == false)
        {
            if (rightThumbAndIndexDistanceC > 0.04 && rightThumbAndIndexDistanceC < 0.07 &&
                fingers.RightMiddleOpen == false && fingers.RightRingOpen == false && fingers.RightPinkyOpen == false)
            {
                Debug.Log("C");
                CSigned = true;
                CPracticed = true;
            }
            else
            {
                CSigned = false;
            }
        }
        else if(leftHand.activeInHierarchy == true && rightHand.activeInHierarchy == true)
        {
            if (rightThumbAndIndexDistanceC > 0.04 && rightThumbAndIndexDistanceC < 0.07 &&
                fingers.RightMiddleOpen == false && fingers.RightRingOpen == false && fingers.RightPinkyOpen == false)
            {
                Debug.Log("C");
                CSigned = true;
                CPracticed = true;
            }
            else
            {
                CSigned = false;
            }
        }

        // D - Janky
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexTip.bounds) &&
            colliders.RightThumbTip.bounds.Intersects(colliders.LeftIndexBot.bounds))
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftMiddleBot.bounds) &&
            colliders.RightMiddleTip.bounds.Intersects(colliders.LeftMiddleMid.bounds))
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
