using UnityEngine;
using System.Collections;

public class RocketEngine : MonoBehaviour {
	public float speed = 50f;
	//public float radius = 5.0F;
	//public float power = 10.0F;
	//public float force;


	// Use this for initialization
	void Start () 
	{

	}
	 	 	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//GameObject player = GameObject.Find ("Player");
		//player.GetComponent<FirstPersonScript> ();
		transform.Translate (transform.up * speed * Time.deltaTime, Space.World);
		//player.GetComponent<Rigidbody> ();

	}


}
