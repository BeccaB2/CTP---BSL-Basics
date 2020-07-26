using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsTransition : MonoBehaviour 
{
	public bool finishedWait;

	// Use this for initialization
	void Start () 
	{
		finishedWait = false;

		if(SceneManager.GetActiveScene().name == "InstructionsDT")
		{
			StartCoroutine(ScreenTransitionWait());

			if(finishedWait == true)
			{
				SceneManager.LoadScene(2);
			}
		}
		else if(SceneManager.GetActiveScene().name == "InstructionsVR")
		{
			StartCoroutine(ScreenTransitionWait());

			if (finishedWait == true)
			{
				SceneManager.LoadScene(7);
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (SceneManager.GetActiveScene().name == "InstructionsDT")
		{			
			if (finishedWait == true)
			{
				SceneManager.LoadScene(2);
			}
		}
		else if (SceneManager.GetActiveScene().name == "InstructionsVR")
		{
			if (finishedWait == true)
			{
				SceneManager.LoadScene(7);
			}
		}
	}

	IEnumerator ScreenTransitionWait()
	{
		yield return new WaitForSeconds(10);
		finishedWait = true;
	}
}
