using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageVisibility : MonoBehaviour
{
    GameObject hands;
    CollisionDetectionVowels vowelCollision;

    CollisionDetectionCons1 consonantCollision1;
    CollisionDetectionCons2 consonantCollision2;
    CollisionDetectionCons3 consonantCollision3;
    CollisionDetectionCons4 consonantCollision4;
    CollisionDetectionCons5 consonantCollision5;

    GameObject ui;
    VowelTasks progress;

    // Use this for initialization
    void Start ()
    {
        // Finding the hand object
        if(SceneManager.GetActiveScene().name == "MountedHandDemo" || 
           SceneManager.GetActiveScene().name == "VowelPracticeVR")
        {
            hands = GameObject.Find("LeapHandController");
        }
        else
        {
            hands = GameObject.Find("HandModels");
        }
        
        // Finding the collision checking scripts - attached to the hand object
        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();
        consonantCollision1 = hands.GetComponent<CollisionDetectionCons1>();
        consonantCollision2 = hands.GetComponent<CollisionDetectionCons2>();
        consonantCollision3 = hands.GetComponent<CollisionDetectionCons3>();
        consonantCollision4 = hands.GetComponent<CollisionDetectionCons4>();
        consonantCollision5 = hands.GetComponent<CollisionDetectionCons5>();

        // Finding the vowel practice task script
        ui = GameObject.Find("Background");
        progress = ui.GetComponent<VowelTasks>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "2 - VowelPracticeDT" || SceneManager.GetActiveScene().name == "VowelPracticeVR")
        {
            EnableTick();
            DisableTick();
        }
        else if (SceneManager.GetActiveScene().name == "3 - VowelChallengeDT")
        {
            DisableQuestionMark();
        }
        else if (SceneManager.GetActiveScene().name == "DesktopHandDemo" || SceneManager.GetActiveScene().name == "MountedHandDemo")
        {
            EnableImagesVowels();
            EnableImagesCons1();
            EnableImagesCons2();
            EnableImagesCons3();
            EnableImagesCons4();
            EnableImagesCons5();
        }  
        else if(SceneManager.GetActiveScene().name == "4 - ConsonantPractice1DT")
        {
            
        }
    }

    private void EnableTick()
    {
        // May need to encompass this in if to check what scene we are in
        if (vowelCollision.APracticed == true)
        {
            GameObject.Find("A_Tick").GetComponent<Image>().enabled = true;
        }

        if (vowelCollision.EPracticed == true)
        {
            GameObject.Find("E_Tick").GetComponent<Image>().enabled = true;
        }

        if (vowelCollision.IPracticed == true)
        {
            GameObject.Find("I_Tick").GetComponent<Image>().enabled = true;
        }

        if (vowelCollision.OPracticed == true)
        {
            GameObject.Find("O_Tick").GetComponent<Image>().enabled = true;
        }

        if (vowelCollision.UPracticed == true)
        {
            GameObject.Find("U_Tick").GetComponent<Image>().enabled = true;
        }
    }

    private void DisableTick()
    {
        if (vowelCollision.APracticed == true && vowelCollision.EPracticed == true &&
            vowelCollision.IPracticed == true && vowelCollision.OPracticed == true &&
            vowelCollision.UPracticed == true && progress.practicedTask == true)
        {
            StartCoroutine(RemoveTicks());
        }
    }

    IEnumerator RemoveTicks()
    {
        yield return new WaitForSeconds(1f);

        if (progress.completedTask == false)
        {
            GameObject.Find("A_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("E_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("I_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("O_Tick").GetComponent<Image>().enabled = false;
            GameObject.Find("U_Tick").GetComponent<Image>().enabled = false;
        }
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

    private void EnableImagesCons1()
    {
        // B
        if (consonantCollision1.BSigned == true)
        {
            GameObject.Find("B").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("B").GetComponent<Image>().enabled = false;
        }

        // C
        if (consonantCollision1.CSigned == true)
        {
            GameObject.Find("C").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("C").GetComponent<Image>().enabled = false;
        }

        // D
        if (consonantCollision1.DSigned == true)
        {
            GameObject.Find("D").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("D").GetComponent<Image>().enabled = false;
        }

        // F
        if (consonantCollision1.FSigned == true)
        {
            GameObject.Find("F").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("F").GetComponent<Image>().enabled = false;
        }
    }

    private void EnableImagesCons2()
    {
        // G
        if (consonantCollision2.GSigned == true)
        {
            GameObject.Find("G").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("G").GetComponent<Image>().enabled = false;
        }

        // H
        if (consonantCollision2.HSigned == true)
        {
            GameObject.Find("H").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("H").GetComponent<Image>().enabled = false;
        }

        // J
        if (consonantCollision2.JSigned == true)
        {
            GameObject.Find("J").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("J").GetComponent<Image>().enabled = false;
        }

        // K
        if (consonantCollision2.KSigned == true)
        {
            GameObject.Find("K").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("K" +
                "").GetComponent<Image>().enabled = false;
        }
    }

    private void EnableImagesCons3()
    {
        // L
        if (consonantCollision3.LSigned == true)
        {
            GameObject.Find("L").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("L").GetComponent<Image>().enabled = false;
        }

        // M
        if (consonantCollision3.MSigned == true)
        {
            GameObject.Find("M").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("M").GetComponent<Image>().enabled = false;
        }

        // N
        if (consonantCollision3.NSigned == true)
        {
            GameObject.Find("N").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("N").GetComponent<Image>().enabled = false;
        }

        // P
        if (consonantCollision3.PSigned == true)
        {
            GameObject.Find("P").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("P").GetComponent<Image>().enabled = false;
        }
    }

    private void EnableImagesCons4()
    {
        // Q
        if (consonantCollision4.QSigned == true)
        {
            GameObject.Find("Q").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("Q").GetComponent<Image>().enabled = false;
        }

        // R
        if (consonantCollision4.RSigned == true)
        {
            GameObject.Find("R").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("R").GetComponent<Image>().enabled = false;
        }

        // S
        if (consonantCollision4.SSigned == true)
        {
            GameObject.Find("S").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("S").GetComponent<Image>().enabled = false;
        }

        // T
        if (consonantCollision4.TSigned == true)
        {
            GameObject.Find("T").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("T").GetComponent<Image>().enabled = false;
        }
    }

    private void EnableImagesCons5()
    {
        // V
        if (consonantCollision5.VSigned == true)
        {
            GameObject.Find("V").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("V").GetComponent<Image>().enabled = false;
        }

        // W
        if (consonantCollision5.WSigned == true)
        {
            GameObject.Find("W").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("W").GetComponent<Image>().enabled = false;
        }

        // X
        if (consonantCollision5.XSigned == true)
        {
            GameObject.Find("X").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("X").GetComponent<Image>().enabled = false;
        }

        // Y
        if (consonantCollision5.YSigned == true)
        {
            GameObject.Find("Y").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("Y").GetComponent<Image>().enabled = false;
        }

        // Z
        if (consonantCollision5.ZSigned == true)
        {
            GameObject.Find("Z").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("Z").GetComponent<Image>().enabled = false;
        }
    }

    private void EnableImagesVowels()
    {
        // A
        if (vowelCollision.ASigned == true)
        {
            GameObject.Find("A").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("A").GetComponent<Image>().enabled = false;
        }

        // E
        if (vowelCollision.ESigned == true)
        {
            GameObject.Find("E").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("E").GetComponent<Image>().enabled = false;
        }

        // I
        if (vowelCollision.ISigned == true)
        {
            GameObject.Find("I").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("I").GetComponent<Image>().enabled = false;
        }

        // O
        if (vowelCollision.OSigned == true)
        {
            GameObject.Find("O").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("O").GetComponent<Image>().enabled = false;
        }

        // U
        if (vowelCollision.USigned == true)
        {
            GameObject.Find("U").GetComponent<Image>().enabled = true;
        }
        else
        {
            GameObject.Find("U").GetComponent<Image>().enabled = false;
        }
    }
}
