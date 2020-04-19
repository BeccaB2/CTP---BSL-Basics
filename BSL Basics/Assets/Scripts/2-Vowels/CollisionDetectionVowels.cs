using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectionVowels : MonoBehaviour
{
    GameObject hands;
    FindColliders colliders;
    HandClosureChecking fingers;

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
        // Initialising booleans
        InitBools();

        // Finding hand objects and collision scripts
        FindHandsAndCollisionScripts();
    }

    private void InitBools()
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
    }

    private void FindHandsAndCollisionScripts()
    {
        // Finding the correct hand object - the hands have different names for desktop & VR
        if (SceneManager.GetActiveScene().name == "MountedHandDemo" ||
            SceneManager.GetActiveScene().name == "VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }

        // Finding the colliders - can use only what we need
        colliders = hands.GetComponent<FindColliders>();

        // Finding the hand closure script
        fingers = hands.GetComponent<HandClosureChecking>();
    }

    void Update()
    {
        // Checks what fingers are touching
        CheckCollision();
    }

    private void CheckCollision()
    {
        // Checks if the two colliders intersect
        // A
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftThumbTip.bounds) &&
            fingers.LeftAllOpen == true && fingers.OnlyRightIndexOpen == true)
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftIndexTip.bounds) &&
            fingers.LeftAllOpen == true && fingers.OnlyRightIndexOpen == true)
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftMiddleTip.bounds) &&
            fingers.LeftAllOpen == true && fingers.OnlyRightIndexOpen == true)
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftRingTip.bounds) &&
            fingers.LeftAllOpen == true && fingers.OnlyRightIndexOpen == true)
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
        if (colliders.RightIndexTip.bounds.Intersects(colliders.LeftPinkyTip.bounds) &&
            fingers.LeftAllOpen == true && fingers.OnlyRightIndexOpen == true)
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
