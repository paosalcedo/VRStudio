using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttackScript : MonoBehaviour {
	public GameObject wave;
	GameObject aimGuide; 
	GameObject launcher;
	//public float rocketImpulse = 50.0f;
	//	public float cooldown =1f;
	//public float ballCooldown;
	//	public float cooldownRemaining;
	//public AudioSource rocketSound;
	public float timeUntilNextWave;
	public float minTimeUntilNextWave;
	public float maxTimeUntilNextWave;
	public bool enableWaves;
	AudioSource fire;

	// Use this for initialization
	//Rigidbody rb;

	void Start () {
		aimGuide = GameObject.Find ("WaveAimGuide");
		aimGuide.SetActive (false);
		//	rb = GetComponent<Rigidbody> ();
		//rocketSound = GetComponent<AudioSource>();
		launcher = GameObject.Find ("WaveLauncher");
		fire = GetComponent<AudioSource> ();
		//timeUntilNextWave = 10f;

	}

	// Update is called once per frame
	void Update () {
		timeUntilNextWave -= Time.deltaTime;
		//		cooldownRemaining -= Time.deltaTime;
		//		cooldownRemaining = Mathf.Clamp (cooldownRemaining, -0.1f, 0.5f);

		//		if (Input.GetMouseButtonDown (0) || Input.GetButtonDown("Jump") && cooldownRemaining <= 0) 
		if (timeUntilNextWave <= 0 && enableWaves == true)
		{
			//Debug.Log ("Fire!");
			//			cooldownRemaining = ballCooldown;
			//rocketSound.Play(); 
			Instantiate (wave, launcher.transform.position, launcher.transform.rotation);
			timeUntilNextWave = Random.Range (minTimeUntilNextWave, maxTimeUntilNextWave);
			fire.Play ();
			//Camera cam = Camera.main;
			//GameObject theRocket = (GameObject)Instantiate (rocketPrefab, cam.transform.position, cam.transform.rotation);
			//rb.AddForce (cam.transform.forward * rocketImpulse, ForceMode.Impulse);
		}
	}
}
