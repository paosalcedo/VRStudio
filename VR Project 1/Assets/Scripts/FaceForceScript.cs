using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceForceScript : MonoBehaviour {
//	GameObject[] balls;
//	GameObject ball;

//	public bool hasDeflected;
	// Use this for initialization
	void Start () {
		//balls = GameObject.FindGameObjectsWithTag("Ball");
//		hasDeflected = false;
	}
	
	// Update is called once per frame
	void Update ()	 {

		//if(Camera.main.transform.Translate (0f, 2f, 0f));//return to normal head height
//		hasDeflected = false;
		//head facing right
		if (Camera.main.transform.eulerAngles.y > 10f && Camera.main.transform.eulerAngles.y <= 180f) 
		{
//			hasDeflected = true;
			//hasDeflected = false;
		}

		//head facing left
		if (Camera.main.transform.eulerAngles.y < 350f && Camera.main.transform.eulerAngles.y > 180f ) 
		{			
//			hasDeflected = true;

			//hasDeflected = false;
		}

	}
//	void ResetDeflect()
//	{
//			hasDeflected = false;
//	}

//	void FaceForceLeft()
//	{
//			ball.SendMessage ("DeflectLeft");
//			Debug.Log ("MESSAGE TO DEFLECTLEFT RECEIVED!");
//	}
//
//	void FaceForceRight()
//	{
//		foreach (GameObject ball in balls) {
//			ball.SendMessage ("DeflectRight");
//			Debug.Log ("MESSAGE TO DEFLECTRIGHT RECEIVED!");
//		}
//	}

}
