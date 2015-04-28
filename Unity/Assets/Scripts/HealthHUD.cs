using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthHUD : MonoBehaviour
{

    private GameObject MainCamera;
    private Slider slider;

	// Use this for initialization
	void Start ()
    {
        MainCamera = GameObject.Find("Main Camera");
	    slider = GetComponent<Slider>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    slider.value = MainCamera.GetComponent<Health>().health;
	}
}
