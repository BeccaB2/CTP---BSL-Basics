using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterConflictTesting : MonoBehaviour
{
    GameObject hands;

    CollisionDetectionVowels vowelCollision;
    CollisionDetectionCons1 consonantCollision1;
    CollisionDetectionCons2 consonantCollision2;
    CollisionDetectionCons3 consonantCollision3;
    CollisionDetectionCons4 consonantCollision4;
    CollisionDetectionCons5 consonantCollision5;

    public bool ASigned;
    public bool BSigned;
    public bool CSigned;
    public bool DSigned;
    public bool ESigned;
    public bool FSigned;
    public bool GSigned;
    public bool HSigned;
    public bool ISigned;
    public bool JSigned;
    public bool KSigned;
    public bool LSigned;
    public bool MSigned;
    public bool NSigned;
    public bool OSigned;
    public bool PSigned;
    public bool QSigned;
    public bool RSigned;
    public bool SSigned;
    public bool TSigned;
    public bool USigned;
    public bool VSigned;
    public bool WSigned;
    public bool XSigned;
    public bool YSigned;
    public bool ZSigned;

    // Use this for initialization
    void Start ()
    {
        InitBools();
        FindHandsAndScripts();
    }

    private void InitBools()
    {
        ASigned = false;
        BSigned = false;
        CSigned = false;
        DSigned = false;
        ESigned = false;
        FSigned = false;
        GSigned = false;
        HSigned = false;
        ISigned = false;
        JSigned = false;
        KSigned = false;
        LSigned = false;
        MSigned = false;
        NSigned = false;
        OSigned = false;
        PSigned = false;
        QSigned = false;
        RSigned = false;
        SSigned = false;
        TSigned = false;
        USigned = false;
        VSigned = false;
        WSigned = false;
        XSigned = false;
        YSigned = false;
        ZSigned = false;
    }

    private void FindHandsAndScripts()
    {
        // Finding the correct hand object - the hands have different names for desktop & VR
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
        consonantCollision1 = hands.GetComponent<CollisionDetectionCons1>();
        consonantCollision2 = hands.GetComponent<CollisionDetectionCons2>();
        consonantCollision3 = hands.GetComponent<CollisionDetectionCons3>();
        consonantCollision4 = hands.GetComponent<CollisionDetectionCons4>();
        consonantCollision5 = hands.GetComponent<CollisionDetectionCons5>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (vowelCollision.ASigned == true)
        {
            ASigned = true;
        }
        else
        {
            ASigned = false;
        }

        if (vowelCollision.ESigned == true)
        {
            ESigned = true;
        }
        else
        {
            ESigned = false;
        }

        if (vowelCollision.ISigned == true)
        {
            ISigned = true;
        }
        else
        {
            ISigned = false;
        }

        if (vowelCollision.OSigned == true)
        {
            OSigned = true;
        }
        else
        {
            OSigned = false;
        }

        if (vowelCollision.USigned == true)
        {
            USigned = true;
        }
        else
        {
            USigned = false;
        }

        if (consonantCollision1.BSigned == true)
        {
            BSigned = true;
        }
        else
        {
            BSigned = false;
        }

        if (consonantCollision1.CSigned == true)
        {
            CSigned = true;
        }
        else
        {
            CSigned = false;
        }

        if (consonantCollision1.DSigned == true)
        {
            DSigned = true;
        }
        else
        {
            DSigned = false;
        }

        if (consonantCollision1.FSigned == true)
        {
            FSigned = true;
        }
        else
        {
            FSigned = false;
        }

        if (consonantCollision2.GSigned == true)
        {
            GSigned = true;
        }
        else
        {
            GSigned = false;
        }

        if (consonantCollision2.HSigned == true)
        {
            HSigned = true;
        }
        else
        {
            HSigned = false;
        }

        if (consonantCollision2.JSigned == true)
        {
            JSigned = true;
        }
        else
        {
            JSigned = false;
        }

        if (consonantCollision2.KSigned == true)
        {
            KSigned = true;
        }
        else
        {
            KSigned = false;
        }

        if (consonantCollision3.LSigned == true)
        {
            LSigned = true;
        }
        else
        {
            LSigned = false;
        }

        if (consonantCollision3.MSigned == true)
        {
            MSigned = true;
        }
        else
        {
            MSigned = false;
        }

        if (consonantCollision3.NSigned == true)
        {
            NSigned = true;
        }
        else
        {
            NSigned = false;
        }

        if (consonantCollision3.PSigned == true)
        {
            PSigned = true;
        }
        else
        {
            PSigned = false;
        }

        if (consonantCollision4.QSigned == true)
        {
            QSigned = true;
        }
        else
        {
            QSigned = false;
        }

        if (consonantCollision4.RSigned == true)
        {
            RSigned = true;
        }
        else
        {
            RSigned = false;
        }

        if (consonantCollision4.SSigned == true)
        {
            SSigned = true;
        }
        else
        {
            SSigned = false;
        }

        if (consonantCollision4.TSigned == true)
        {
            TSigned = true;
        }
        else
        {
            TSigned = false;
        }

        if (consonantCollision5.VSigned == true)
        {
            VSigned = true;
        }
        else
        {
            VSigned = false;
        }

        if (consonantCollision5.WSigned == true)
        {
            WSigned = true;
        }
        else
        {
            WSigned = false;
        }

        if (consonantCollision5.XSigned == true)
        {
            XSigned = true;
        }
        else
        {
            XSigned = false;
        }

        if (consonantCollision5.YSigned == true)
        {
            YSigned = true;
        }
        else
        {
            YSigned = false;
        }

        if (consonantCollision5.ZSigned == true)
        {
            ZSigned = true;
        }
        else
        {
            ZSigned = false;
        }
    }
}
