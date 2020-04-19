using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionCons3 : MonoBehaviour
{
    GameObject hands;
    FindColliders colliders;

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
        // Initialising booleans
        InitBools();

        // Finding hands and colliders
        FindHandsAndColliders();
    }

    private void InitBools()
    {
        LSigned = false;
        MSigned = false;
        NSigned = false;
        PSigned = false;

        LPracticed = false;
        MPracticed = false;
        NPracticed = false;
        PPracticed = false;
    }

    private void FindHandsAndColliders()
    {
        // Finding the hand object
        if (SceneManager.GetActiveScene().name == "MountedHandDemo" ||
            SceneManager.GetActiveScene().name == "VowelPracticeVR")
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
        // L
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexPalm.bounds))
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexPalm.bounds) &&
            colliders.RightMiddleTip.bounds.Intersects(colliders.LeftIndexPalm.bounds) &&
            colliders.RightRingTip.bounds.Intersects(colliders.LeftIndexPalm.bounds))
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexPalm.bounds) &&
            colliders.RightMiddleTip.bounds.Intersects(colliders.LeftIndexPalm.bounds))
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.RightThumbTip.bounds) &&
            colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexTip.bounds) &&
            colliders.RightThumbTip.bounds.Intersects(colliders.LeftIndexTip.bounds))
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
