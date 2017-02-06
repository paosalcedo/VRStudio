using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveEngine : MonoBehaviour {

	//public float speed = 50f;
	//public float radius = 5.0F;
	//public float power = 10.0F;
	//public float force;
	public float force;
	public float deflectForceUp;
	public float deflectRange;
	public float minDeflectAngle;
	public float maxDeflectAngle;
	//	public float deflectForceUp;
	public float timeAlive;
	Rigidbody rb;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//rb.AddForce(Vector3.back * force); //move the projectiles using AddForce
		transform.Translate (transform.up * force * Time.deltaTime, Space.World); //move the projectiles

		DeflectUp ();

		//kill balls 
		timeAlive -= Time.deltaTime;
		if (timeAlive <= 0f) 
		{
			Destroy (gameObject);
		}

	}

//	void DeflectLeft()
//	{
//		//		if (!GameObject.Find ("Main Camera").GetComponent<FaceForceScript> ().hasDeflected 
//		//			&& Vector3.Distance (rb.transform.position, Camera.main.transform.position) < 10f 
//		//			&& Camera.main.transform.eulerAngles.y < 350f 
//		//			&& Camera.main.transform.eulerAngles.y > 180f) 
//		//Debug.Log("Deflect left!");
//		if (Vector3.Distance (rb.transform.position, Camera.main.transform.position) < deflectRange 
//			&& Camera.main.transform.eulerAngles.y < 350f 
//			&& Camera.main.transform.eulerAngles.y > 180f) 
//		{
//			rb.AddForce (Vector3.left * deflectForce);
//		}
//	}

	//	void DeflectRight()
	//	{
	//		if (Vector3.Distance (rb.transform.position, Camera.main.transform.position) < deflectRange 
	//			&& Camera.main.transform.eulerAngles.y > 10f 
	//			&& Camera.main.transform.eulerAngles.y <= 180f) 
	//		{
	//			rb.AddForce (Vector3.right * deflectForce);
	//		}
	//	}



		void DeflectUp()
		{
		if (Vector3.Distance (rb.transform.position, Camera.main.transform.position) < deflectRange 
			&& Camera.main.transform.eulerAngles.x < minDeflectAngle 
			&& Camera.main.transform.eulerAngles.x > maxDeflectAngle || Input.GetButtonDown("Jump")) 
			{
			Debug.Log ("green DEFLECT");
			//rb.AddForce (Vector3.up * deflectForceUp);
			rb.AddExplosionForce(deflectForceUp, rb.transform.position, 25f);
			}
		}

}
