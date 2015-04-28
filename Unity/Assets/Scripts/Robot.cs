using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour
{

	GameObject rob;

	// Use this for initialization
	void Start ()
    {
		rob = GameObject.Find ("Robot Kyle");
	}
	
	// Update is called once per frame
	void Update () {
		rob.GetComponent<Animation>().Play ("Robot_animation");
	}
}
