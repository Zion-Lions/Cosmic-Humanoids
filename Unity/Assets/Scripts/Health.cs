using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
	public int health;
	// Use this for initialization
	void Start ()
    {	
		Random r = new Random ();
		if (gameObject.name == "Robot Kyle")
						health = Random.Range (10, 150);
				else
						health = 100;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void ApplyDamage(int Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
