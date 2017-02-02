using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR; //add Unity VR's namespace


public class MyMouseLook : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		if (VRDevice.isPresent == true) {
			Debug.Log ("VR is enabled! " + VRDevice.model);
		} else {
			Camera.main.transform.Translate (0f, 2f, 0f);//return to normal head height
		}

		VRSettings.renderViewportScale = 0.1f; //render at 10% of original resolution
	}
	
	// Update is called once per frame
	void Update () {
		if (VRDevice.isPresent == false) {
			//do backup emergency input code only if VR isn't working
			var myCam = Camera.main.transform;

			//rotate camera based on mouse delta speed
			myCam.Rotate (-Input.GetAxis ("Mouse Y"), Input.GetAxis ("Mouse X"), 0f);

			//unroll our camera
			myCam.localEulerAngles = new Vector3 (myCam.localEulerAngles.x, myCam.localEulerAngles.y, 0f); 
		}
	
		//any code here; will work regardless of presence of VR device	
	}
}
