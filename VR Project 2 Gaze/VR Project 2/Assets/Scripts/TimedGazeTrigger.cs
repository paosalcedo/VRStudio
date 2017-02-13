using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TimedGazeTrigger : MonoBehaviour {

	// "SerializeField" exposes private vars to the inspector.
	[SerializeField] float timeLookedAt = 0f; //time, in seconds, spent looking at thing
	public Image progressImage; 

	public UnityEvent OnGazeComplete = new UnityEvent(); 
	public float lookDelay = 0.5f;
	public bool art1Complete;
	public bool art2Complete;
	public bool art3Complete;
	public bool art4Complete;
	GameObject art1;
	GameObject art2;
	GameObject art3;
	GameObject art4;
	bool art1Bool;

	void Start(){
		art1Complete = false;
		art2Complete = false;
		art3Complete = false;
		art4Complete = false;
		art1 = GameObject.Find ("Art2Trigger");
		art2 = GameObject.Find ("Art1Trigger");
		art3 = GameObject.Find ("Art4Trigger");
		art4 = GameObject.Find ("Art3Trigger");
	}

	void Update () {

		//1. is the camera looking / pointing at something?
		Vector3 camLookDir = Camera.main.transform.forward; 
		Vector3 vectorFromCamToTarget = transform.position - Camera.main.transform.position; 

		//get the angle between our lookDir vs. the object's direction
		float angle = Vector3.Angle(camLookDir, vectorFromCamToTarget);

		// do stuff based on that angle
		if(this.gameObject.name == "Art2Trigger" && !art1Complete){
			if (angle < 5f) {
				//transform.localScale *= 1.01f; //if we are looking within 15 degree FoV, grow object
				timeLookedAt = Mathf.Clamp01(timeLookedAt + Time.deltaTime * lookDelay); //after 1 second, this variable will be 1f 
				//did we reach 100%? if so, fire the event and reset.
				if (timeLookedAt == 1f) {
					timeLookedAt = 0f;
					OnGazeComplete.Invoke ();
					art1Complete = true;
				}
			} else {
				//"decay" progress if not looking. 
				timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);
			} 

			//update our UI image
			progressImage.fillAmount = timeLookedAt; // fillAmount is a float from 0-1.
		} 


		if (this.gameObject.name == "Art1Trigger" && GameObject.Find("Art2Trigger").GetComponent<TimedGazeTrigger>().art1Complete) {
			if (angle < 5f) {
				//transform.localScale *= 1.01f; //if we are looking within 15 degree FoV, grow object
				timeLookedAt = Mathf.Clamp01(timeLookedAt + Time.deltaTime * lookDelay); //after 1 second, this variable will be 1f 
				//did we reach 100%? if so, fire the event and reset.

				if (timeLookedAt == 1f) {
					timeLookedAt = 0f;
					OnGazeComplete.Invoke ();
					art2Complete = true;
				}
			} else {
				//"decay" progress if not looking. 
				timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);
			} 

			//update our UI image
			progressImage.fillAmount = timeLookedAt; // fillAmount is a float from 0-1.
		} 
			
		if (this.gameObject.name == "Art4Trigger" && GameObject.Find("Art1Trigger").GetComponent<TimedGazeTrigger>().art2Complete) {
			if (angle < 5f) {
				//transform.localScale *= 1.01f; //if we are looking within 15 degree FoV, grow object
				timeLookedAt = Mathf.Clamp01(timeLookedAt + Time.deltaTime * lookDelay); //after 1 second, this variable will be 1f 
				//did we reach 100%? if so, fire the event and reset.

				if (timeLookedAt == 1f) {
					timeLookedAt = 0f;
					OnGazeComplete.Invoke ();
					art3Complete = true;
				}
			} else {
				//"decay" progress if not looking. 
				timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);
			} 

			//update our UI image
			progressImage.fillAmount = timeLookedAt; // fillAmount is a float from 0-1.
		} 

		if (this.gameObject.name == "Art3Trigger" && GameObject.Find("Art4Trigger").GetComponent<TimedGazeTrigger>().art3Complete) {
			if (angle < 5f) {
				//transform.localScale *= 1.01f; //if we are looking within 15 degree FoV, grow object
				timeLookedAt = Mathf.Clamp01(timeLookedAt + Time.deltaTime * lookDelay); //after 1 second, this variable will be 1f 
				//did we reach 100%? if so, fire the event and reset.

				if (timeLookedAt == 1f) {
					timeLookedAt = 0f;
					OnGazeComplete.Invoke ();
					art4Complete = true; 
				}
			} else {
				//"decay" progress if not looking. 
				timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);
			} 

			//update our UI image
			progressImage.fillAmount = timeLookedAt; // fillAmount is a float from 0-1.
		}
	}
}
