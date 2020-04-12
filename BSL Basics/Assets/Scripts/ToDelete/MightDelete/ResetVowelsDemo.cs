using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetVowelsDemo : MonoBehaviour
{
    public GameObject hands;
    CollisionDetectionVowels vowelCollision;

    // Use this for initialization
    void Start ()
    {
        vowelCollision = hands.GetComponent<CollisionDetectionVowels>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (vowelCollision.ASigned == true)
        {
            StartCoroutine(Wait());
        }

        if (vowelCollision.ESigned == true)
        {
            StartCoroutine(Wait());         
        }

        if (vowelCollision.ISigned == true)
        {
            StartCoroutine(Wait());            
        }
        
        if (vowelCollision.OSigned == true)
        {
            StartCoroutine(Wait());
        }
            
        if (vowelCollision.USigned == true)
        {
            StartCoroutine(Wait());
        }
       
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        vowelCollision.ASigned = false;
        vowelCollision.ESigned = false;
        vowelCollision.ISigned = false;
        vowelCollision.OSigned = false;
        vowelCollision.USigned = false;
    }
}
