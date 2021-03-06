﻿using UnityEngine;
using System.Collections;

public class AttackScript : MonoBehaviour {

	public GameObject ball;
	GameObject aimGuide; 
	GameObject launcher;
	//public float rocketImpulse = 50.0f;
//	public float cooldown =1f;
	//public float ballCooldown;
//	public float cooldownRemaining;
	//public AudioSource rocketSound;
	public float timeUntilNextBall;
	public float minTimeUntilNextBall;
	public float maxTimeUntilNextBall;
	public bool enableBalls;
	AudioSource fire;

	// Use this for initialization
	//Rigidbody rb;

	void Start () {
		aimGuide = GameObject.Find ("BlueAimGuide");
		aimGuide.SetActive (false);
		launcher = GameObject.Find ("BlueLauncher");
		timeUntilNextBall = 2f;
		fire = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		timeUntilNextBall -= Time.deltaTime;
//		cooldownRemaining -= Time.deltaTime;
//		cooldownRemaining = Mathf.Clamp (cooldownRemaining, -0.1f, 0.5f);

//		if (Input.GetMouseButtonDown (0) || Input.GetButtonDown("Jump") && cooldownRemaining <= 0) 
		if (timeUntilNextBall <= 0 && enableBalls == true)
		{
			//Debug.Log ("Fire!");
//			cooldownRemaining = ballCooldown;
			//rocketSound.Play(); 
			Instantiate (ball, launcher.transform.position, launcher.transform.rotation);
			timeUntilNextBall = Random.Range (minTimeUntilNextBall, maxTimeUntilNextBall);
			fire.Play ();
			//Camera cam = Camera.main;
			//GameObject theRocket = (GameObject)Instantiate (rocketPrefab, cam.transform.position, cam.transform.rotation);
			//rb.AddForce (cam.transform.forward * rocketImpulse, ForceMode.Impulse);
		}
	}
}
