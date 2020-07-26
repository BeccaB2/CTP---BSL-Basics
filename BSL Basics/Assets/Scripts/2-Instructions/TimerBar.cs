using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour 
{
	public Slider slider;
	float timer;
	int seconds;

	// Use this for initialization
	void Start () 
	{
		slider = GameObject.Find("Timer").GetComponent<Slider>();

		timer = 0.0f;
		slider.value = timer;

		//StartCoroutine(TimerIncrease());
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		slider.value = Mathf.Lerp(0.0f, 1.0f, timer / 10);
	}
}
