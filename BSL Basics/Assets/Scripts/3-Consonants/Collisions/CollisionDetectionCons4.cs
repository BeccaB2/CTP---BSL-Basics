using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionCons4 : MonoBehaviour
{
    GameObject hands;
    FindColliders colliders;

    public bool QSigned;
    public bool RSigned;
    public bool SSigned;
    public bool TSigned;

    public bool QPracticed;
    public bool RPracticed;
    public bool SPracticed;
    public bool TPracticed;

    void Start()
    {
        // Initialising booleans
        InitBools();

        // Finding hands and colliders
        FindHandsAndColliders();
    }

    private void InitBools()
    {
        QSigned = false;
        RSigned = false;
        SSigned = false;
        TSigned = false;

        QPracticed = false;
        RPracticed = false;
        SPracticed = false;
        TPracticed = false;
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
        // Q
        if (colliders.LeftIndexTip.bounds.Intersects(colliders.LeftThumbTip.bounds) &&
            colliders.RightIndexTip.bounds.Intersects(colliders.LeftThumbMid.bounds))
        {
            Debug.Log("Q");
            QSigned = true;
            QPracticed = true;
        }
        else
        {
            QSigned = false;
        }

        // R
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftPinkyPalm.bounds) &&
            colliders.RightIndexMid.bounds.Intersects(colliders.LeftPinkyPalm.bounds))
        {
            Debug.Log("R");
            RSigned = true;
            RPracticed = true;
        }
        else
        {
            RSigned = false;
        }

        // S
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftPinkyBot.bounds))
        {
            Debug.Log("S");
            SSigned = true;
            SPracticed = true;
        }
        else
        {
            SSigned = false;
        }

        // T
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftPinkyPalm.bounds))
        {
            Debug.Log("T");
            TSigned = true;
            TPracticed = true;
        }
        else
        {
            TSigned = false;
        }
    }
}
