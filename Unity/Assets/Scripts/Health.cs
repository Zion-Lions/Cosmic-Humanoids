using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{

    public int health;

	// Use this for initialization
	void Start ()
    {
	
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
