using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VowelTasks : MonoBehaviour
{
    public bool practicedTask;
    public bool completedTask;
    public bool waitComplete;

    GameObject hands;
    CollisionDetectionVowels vowelCollision;

    // Use this for initialization
    void Start ()
    {
        practicedTask = false;
        completedTask = false;

        if (SceneManager.GetActiveScene().name == "2 - VRHandDemo" ||
           SceneManager.GetActiveScene().name == "1 - VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }

        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "1 - VowelPracticeDT" || SceneManager.GetActiveScene().name == "1 - VowelPracticeVR")
        {
            PracticeTaskProgress();

        }
        else if (SceneManager.GetActiveScene().name == "2 - VowelChallengeDT")
        {
            ChallengeProgess();
        }
    }

    private void PracticeTaskProgress()
    {
        if (vowelCollision.APracticed == true && vowelCollision.EPracticed == true &&
            vowelCollision.IPracticed == true && vowelCollision.OPracticed == true && vowelCollision.UPracticed == true)
        {
            if (practicedTask == false)
            {
                practicedTask = true;
                Practiced();
            }

            if (practicedTask == true)
            {
                StartCoroutine(ResetPracticedBools());
            }

            if (completedTask == false && waitComplete == true && practicedTask == true)
            {
                completedTask = true;
                Completed();
            }
        }
    }

    IEnumerator ResetPracticedBools()
    {
        yield return new WaitForSeconds(1f);

        if (completedTask == false)
        {
            vowelCollision.APracticed = false;
            vowelCollision.EPracticed = false;
            vowelCollision.IPracticed = false;
            vowelCollision.OPracticed = false;
            vowelCollision.UPracticed = false;
        }
    }
    private void ChallengeProgess()
    {
        if (vowelCollision.APracticed == true && vowelCollision.EPracticed == true &&
            vowelCollision.IPracticed == true && vowelCollision.OPracticed == true && vowelCollision.UPracticed == true)
        {
            GameObject.Find("WellDone").GetComponent<Text>().enabled = true;
            StartCoroutine(WaitForNextStage());
        }
    }

    void Practiced()
    {
        if(practicedTask == true)
        {
            GameObject.Find("PracticeRun").GetComponent<Text>().enabled = true;
            StartCoroutine(WaitToRemovePracticeText());
        }
    }

    void Completed()
    {
        if (completedTask == true)
        {
            GameObject.Find("WellDone").GetComponent<Text>().enabled = true;
            StartCoroutine(WaitForNextStage());
        }
    }

    IEnumerator WaitToRemovePracticeText()
    {
        yield return new WaitForSeconds(2f);

        waitComplete = true;
        GameObject.Find("PracticeRun").GetComponent<Text>().enabled = false;
    }

    IEnumerator WaitForNextStage()
    {
        yield return new WaitForSeconds(3f);

        if (SceneManager.GetActiveScene().name == "1 - VowelPracticeDT")
        { 
            SceneManager.LoadScene(3);
        }
        else if (SceneManager.GetActiveScene().name == "2 - VowelChallengeDT")
        {
            SceneManager.LoadScene(4);
        }    
        else if(SceneManager.GetActiveScene().name == "1 - VowelPracticeVR")
        {
            SceneManager.LoadScene(8);
        }
    }   
}
