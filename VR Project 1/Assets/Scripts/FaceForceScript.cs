using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceForceScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(Camera.main.transform.Translate (0f, 2f, 0f));//return to normal head height
		if (Camera.main.transform.eulerAngles.y > 10f && Camera.main.transform.eulerAngles.y <= 180f) 
		{
			Debug.Log ("head turn right!");
		}

		if (Camera.main.transform.eulerAngles.y < 350f && Camera.main.transform.eulerAngles.y > 180f ) {
			Debug.Log ("head turn left!");
		}

	}
}
