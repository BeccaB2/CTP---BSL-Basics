using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionMarkVisibility : MonoBehaviour {

    public GameObject hands;
    CollisionDetectionVowels vowelCollision;

    // Use this for initialization
    void Start ()
    {
        hands = GameObject.Find("HandModels");
        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        DisableQuestionMark();
    }

    private void DisableQuestionMark()
    {
        if (vowelCollision.APracticed == true)
        {
            GameObject.Find("Question_A").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.EPracticed == true)
        {
            GameObject.Find("Question_E").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.IPracticed == true)
        {
            GameObject.Find("Question_I").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.OPracticed == true)
        {
            GameObject.Find("Question_O").GetComponent<Image>().enabled = false;
        }

        if (vowelCollision.UPracticed == true)
        {
            GameObject.Find("Question_U").GetComponent<Image>().enabled = false;
        }
    }
}
