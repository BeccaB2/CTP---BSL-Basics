using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetVowels : MonoBehaviour
{
    public GameObject hands;
    CollisionDetectionVowels vowelCollision;

    public GameObject ui;
    VowelTasks progress;

    // Use this for initialization
    void Start ()
    {
        // Finding the vowel collision script
        hands = GameObject.Find("HandModels");
        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();

        // Finding the vowel practice task script
        ui = GameObject.Find("Background");
        progress = ui.GetComponent<VowelTasks>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Reset vowels after practice
        if (vowelCollision.APracticed == true && vowelCollision.EPracticed == true && 
            vowelCollision.IPracticed == true && vowelCollision.OPracticed == true && 
            vowelCollision.UPracticed == true && progress.practicedTask == true)
        {
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1f);

        if (progress.completedTask == false)
        {
            vowelCollision.APracticed = false;
            vowelCollision.EPracticed = false;
            vowelCollision.IPracticed = false;
            vowelCollision.OPracticed = false;
            vowelCollision.UPracticed = false;

            GameObject.Find("A_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("E_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("I_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("O_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("U_Tick").GetComponent<Image>().enabled = false;
        }
    }
}
