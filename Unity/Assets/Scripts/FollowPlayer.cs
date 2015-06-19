using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{

	Transform target;
	int moveSpeed = 3;
    Vector3 v;
	//int rotationSpeed = 3;
	

	void Start ()
    {
		target = GameObject.FindWithTag("Player").transform;
	}
	
	void Update ()
    {
		v.Set(target.position.x, transform.position.y, target.position.z);
		transform.LookAt(v);

		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

	}
}