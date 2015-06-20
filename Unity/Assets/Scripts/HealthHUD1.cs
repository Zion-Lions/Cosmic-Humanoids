using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthHUD1 : MonoBehaviour {

    public GameObject Perso;
    public Slider slider;


    void Start()
    {

    }

    void Update()
    {
        slider.value = Perso.GetComponent<Health>().health;
    }
}
