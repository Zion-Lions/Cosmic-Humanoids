using UnityEngine;
using System.Collections;

public class EnnemyHealth : MonoBehaviour {
	int Health;

	void ApplyDamage (int TheDammage)
	{
		Health -= TheDammage;

		if(Health <= 0)
			Dead();
	}

	void Dead()
	{
		Destroy (gameObject);
	}
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
