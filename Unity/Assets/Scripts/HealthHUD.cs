using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthHUD : MonoBehaviour
{

    private GameObject Perso;
    private Slider slider;

	
	void Start ()
    {
        Perso = GameObject.Find("Perso complet");
	    slider = GetComponent<Slider>();
    }
	
	void Update ()
	{
	    slider.value = Perso.GetComponent<Health>().health;
	}
}
