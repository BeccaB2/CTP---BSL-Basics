using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VowelChallenge : MonoBehaviour
{
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
        if (vowelCollision.APracticed == true && vowelCollision.EPracticed == true &&
            vowelCollision.IPracticed == true && vowelCollision.OPracticed == true && vowelCollision.UPracticed == true)
        {
            GameObject.Find("WellDone").GetComponent<Text>().enabled = true;
            StartCoroutine(WaitForNextStage());
        }
    }

    IEnumerator WaitForNextStage()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(3);
    }
}
