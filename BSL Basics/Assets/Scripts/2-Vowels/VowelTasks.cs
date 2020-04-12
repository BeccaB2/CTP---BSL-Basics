﻿using System.Collections;
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

        hands = GameObject.Find("HandModels");
        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (SceneManager.GetActiveScene().name == "2 - VowelPractice")
        {
            PracticeTaskProgress();

        }
        else if (SceneManager.GetActiveScene().name == "3 - VowelChallenge")
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

        if (SceneManager.GetActiveScene().name == "2 - VowelPractice")
        {
            SceneManager.LoadScene(2);
        }
        else if (SceneManager.GetActiveScene().name == "3 - VowelChallenge")
        {
            SceneManager.LoadScene(3);
        }    
    }   
}
