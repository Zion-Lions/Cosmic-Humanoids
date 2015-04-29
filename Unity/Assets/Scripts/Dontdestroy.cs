using UnityEngine;
using System.Collections;

public class Dontdestroy : MonoBehaviour {
	GameObject go;
	// Use this for initialization
	void Start () {
		go = GameObject.Find ("Musique");
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad (go);
	}
}
