﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimedGazeTrigger2 : MonoBehaviour {

	// "SerializeField" exposes private vars to the inspector.
	[SerializeField] float timeLookedAt = 0f; //time, in seconds, spent looking at thing
	//GameObject art1Real;
	public Image progressImage; 
	public UnityEvent OnGazeComplete2 = new UnityEvent(); 
	float lookDelay = 0.5f;
	public bool art1Complete;

	void Start()
	{
		art1Complete = false;
	}

	void Update () {
		//1. is the camera looking / pointing at something?
		Vector3 camLookDir = Camera.main.transform.forward; 
		Vector3 vectorFromCamToTarget = transform.position - Camera.main.transform.position; 

		//get the angle between our lookDir vs. the object's direction
		float angle = Vector3.Angle(camLookDir, vectorFromCamToTarget);

		// do stuff based on that angle

		if (angle < 5f && !art1Complete) {
			//transform.localScale *= 1.01f; //if we are looking within 15 degree FoV, grow object
			timeLookedAt = Mathf.Clamp01(timeLookedAt + Time.deltaTime * lookDelay); //after 1 second, this variable will be 1f 
			//did we reach 100%? if so, fire the event and reset.
			Debug.Log("THIS IS THE WRONG CODE" + this.gameObject.name);
			if (timeLookedAt == 1f) {
				timeLookedAt = 0f;
				OnGazeComplete2.Invoke ();
				if (this.gameObject.name == "Art2Trigger") {
					art1Complete = true;
				}
 
			}
		} else {
			//"decay" progress if not looking. 
			timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);
		} 

		//update our UI image
		progressImage.fillAmount = timeLookedAt; // fillAmount is a float from 0-1.

	}
}
