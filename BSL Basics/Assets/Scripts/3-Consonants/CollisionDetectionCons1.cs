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
        FindHandsAndColliders();
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

    private void FindHandsAndColliders()
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
        // B - Janky
        if (colliders.LeftIndexTip.bounds.Intersects(colliders.RightIndexTip.bounds) &&
            colliders.LeftThumbTip.bounds.Intersects(colliders.RightThumbTip.bounds) &&
            colliders.LeftIndexTip.bounds.Intersects(colliders.LeftThumbTip.bounds) &&
            colliders.RightIndexTip.bounds.Intersects(colliders.RightThumbTip.bounds))
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
        float rightThumbAndIndexDistanceC = Vector3.Distance(colliders.RightIndexTip.transform.position, colliders.RightThumbTip.transform.position);

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
