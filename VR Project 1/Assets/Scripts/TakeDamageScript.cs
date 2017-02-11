using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageScript : MonoBehaviour {

	public float damageAlertTime;
	public AudioSource ouch;
	GameObject redScreen;
	GameObject audioHolder1;
	GameObject audioHolder2;
	GameObject player;
	// Use this for initialization
	void Start () {
		redScreen = GameObject.Find ("Impact");
		redScreen.SetActive (false);
		ouch = GetComponent<AudioSource> ();
		audioHolder1 = GameObject.Find ("AudioHolder1");
		audioHolder2 = GameObject.Find ("AudioHolder2");
		player = GameObject.Find ("Player");
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
			player.SendMessage ("TakeDamage");

		} 

		if (collision.gameObject.tag == "Deals 2Damage") 
		{
			redScreen.SetActive (true);
			Destroy (collision.gameObject);
			//invoke function for setactive false.
			Invoke ("DamageAlert", damageAlertTime);
			audioHolder1.SendMessage ("PlayOuch");
			player.SendMessage ("TakeDamage");
		}

		if (collision.gameObject.tag == "Deals 3Damage") 
		{
			redScreen.SetActive (true);
			Destroy (collision.gameObject);
			//invoke function for setactive false.
			Invoke ("DamageAlert", damageAlertTime);
			audioHolder2.SendMessage ("PlayOuch");
			player.SendMessage ("TakeDamage");
		}
	}

	void DamageAlert()
	{
		redScreen.SetActive (false);
	}
}
