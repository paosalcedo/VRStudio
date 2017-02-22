using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthquakeScript : MonoBehaviour {
	public float quakeSpeed = 10f;
	public float quakeInterval = 0.05f;
	Rigidbody rb;
	Vector3 originalPos;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();	
		quakeInterval = 5f;
		Invoke("QuakeStop", 15f);
		originalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		quakeInterval -= Time.deltaTime;
		
		if (quakeInterval < 1f && quakeInterval >= 0.75f) {
			QuakeLeft ();
		} 	
		
		if (quakeInterval > 0.5f && quakeInterval <= 0.74f) {
			QuakeRight ();
		}

		if (quakeInterval < 0.5f && quakeInterval > 0f) {
			quakeInterval = 1f;
		}

	

	}

	void QuakeStop(){
		quakeInterval = -1f;
		transform.position = originalPos;		
	}
	void QuakeLeft (){
		transform.Translate(Vector3.up * quakeSpeed * Time.deltaTime);
		transform.Translate(Vector3.left * quakeSpeed * Time.deltaTime);

		//rb.AddForce(Vector3.left * quakeSpeed * Time.deltaTime);
	}

	void QuakeRight(){
		transform.Translate(Vector3.down* quakeSpeed * Time.deltaTime);
		transform.Translate(Vector3.right * quakeSpeed * Time.deltaTime);

		//rb.AddForce(Vector3.right * quakeSpeed * Time.deltaTime);
	}
}
