using UnityEngine;
using System.Collections;

public class NavMeshAI : MonoBehaviour {
	Transform targetToLookAt;
	Vector3 v;
	int currentHealth;
	// Use this for initialization
	void Start () {
		targetToLookAt = GameObject.Find ("MAX").transform;
		currentHealth = GetComponent<Health>().health;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, targetToLookAt.transform.position) <= 5f) {
						GetComponent<Animation> ().Stop ();
			GetComponent<NavMeshAgent> ().speed = 0f;
			transform.LookAt(targetToLookAt.position);
			//tirer
				} 
		else if (Vector3.Distance(transform.position, targetToLookAt.transform.position) >= 50f)
		         {
			GetComponent<Animation> ().Stop ();
			GetComponent<NavMeshAgent> ().speed = 0f;
		}
		else {
			GetComponent<NavMeshAgent> ().destination = targetToLookAt.position;
			GetComponent<Animation>().Play("Robot_animation");
			GetComponent<NavMeshAgent> ().speed = 2f;
				}
		currentHealth = GetComponent<Health>().health;
	}
}
