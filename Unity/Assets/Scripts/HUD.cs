using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD : MonoBehaviour
{
    private GameObject MainCamera;
    Text text;
    // Use this for initialization
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera");
        text = GetComponent<Text>();
        text.fontSize = 25;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = MainCamera.GetComponent<RayShoot>().BulletsLeft + " | " + MainCamera.GetComponent<RayShoot>().AllBulletsLeft;
    }
}
