using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTrigger : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//1. declare your raycast 
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		//2. set up our raycast hit info variable too 

		RaycastHit rayHit = new RaycastHit ();

		//3. we're ready to shoot our raycast
		if (Physics.Raycast (ray, out rayHit, 100f)) {
			if (rayHit.transform == this.transform) {
				transform.localScale *= 1.01f; //grow 1% per frame
			}
		}

	}
}
