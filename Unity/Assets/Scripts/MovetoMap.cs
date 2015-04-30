using UnityEngine;
using System.Collections;

public class MovetoMap : MonoBehaviour 
{

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown("p"))
        {
            Application.LoadLevel("Game");
        }
    }
}
