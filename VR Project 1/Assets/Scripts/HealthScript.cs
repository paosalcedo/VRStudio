using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthScript : MonoBehaviour {

	public Text healthText;

	public float health;
	public float damage;

	// Use this for initialization
	void Start () {
		health = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		healthText.text = health.ToString ("###");
	
		if (health <= 0) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}

	void TakeDamage()
	{
		health -= 10f;
	}

	void RestartGame()
	{
		
	}


}
