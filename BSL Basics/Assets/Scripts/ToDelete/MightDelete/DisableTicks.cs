using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableTicks : MonoBehaviour {

    public GameObject hands;
    CollisionDetectionVowels vowelCollision;

    // Use this for initialization
    void Start()
    {
        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();
    }

    // Update is called once per frame
    void Update()
    {
        DisableTick();
    }

    private void DisableTick()
    {
        // May need to encompass this in if to check what scene we are in
        if (vowelCollision.ASigned == false)
        {
            GameObject.Find("A_Tick").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.ESigned == false)
        {
            GameObject.Find("E_Tick").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.ISigned == false)
        {
            GameObject.Find("I_Tick").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.OSigned == false)
        {
            GameObject.Find("O_Tick").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.USigned == false)
        {
            GameObject.Find("U_Tick").GetComponent<Image>().enabled = false;
        }
    }
}
