using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTextScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
		Invoke ("TextOff", 7.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TextOff()
	{
		gameObject.SetActive (false);
	}
}
