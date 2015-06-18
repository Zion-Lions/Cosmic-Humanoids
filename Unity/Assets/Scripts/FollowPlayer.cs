using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	Transform target;
	int moveSpeed = 3;
	int rotationSpeed = 3;
	Vector3 v;
	// Use this for initialization
	void Start ()
    {
		target = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
		v.Set(target.position.x, transform.position.y, target.position.z);
		transform.LookAt(v);
	}
}