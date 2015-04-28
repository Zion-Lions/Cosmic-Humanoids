﻿using UnityEngine;
using System.Collections;

public class Aim : MonoBehaviour
{

    public bool aim = false;
    public GameObject cam;
    public GameObject viseur;

	// Use this for initialization
	void Start ()
	{
	    cam.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetMouseButtonDown(1))
	    {
	        aim = true;
	        if (aim)
	        {
	            cam.SetActive(true);
	            GameObject.Find("ScopeCam").GetComponent<Animation>().Play("Scope");
                viseur.SetActive(false);
	        }
	    }
	    if (Input.GetMouseButtonUp(1))
	    {
	        
	        if (aim)
	        {
	            StartCoroutine(Unscope());
	        }
	    }
	}

    IEnumerator Unscope()
    {
        GameObject.Find("ScopeCam").GetComponent<Animation>().Play("Unscope");
        yield return new WaitForSeconds(0.250f);
        cam.SetActive(false);
        viseur.SetActive(true);
    }
}
