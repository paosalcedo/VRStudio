using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageScript : MonoBehaviour {

	public float damageAlertTime;
	public AudioSource ouch;
	GameObject redScreen;
	// Use this for initialization
	void Start () {
		redScreen = GameObject.Find ("Impact");
		redScreen.SetActive (false);
		ouch = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Deals Damage") 
		{
			redScreen.SetActive (true);
			Destroy (collision.gameObject);
			//invoke function for setactive false.
			Invoke ("DamageAlert", damageAlertTime);
			ouch.Play ();
		} 
	}

	void DamageAlert()
	{
		redScreen.SetActive (false);
	}
}
