using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowDamageSoundScript : MonoBehaviour {

	AudioSource ouch;
	// Use this for initialization
	void Start () {
		ouch = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

	void PlayOuch()
	{
		ouch.Play ();
	}
}
