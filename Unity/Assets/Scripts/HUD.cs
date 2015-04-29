using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUD : MonoBehaviour
{
    private GameObject MainCamera;
    public GameObject BulletsLeft;
    public GameObject AllBulletsLeft;
    private Text text1;
    private Text text2;
    // Use this for initialization
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera");
        text1 = BulletsLeft.GetComponent<Text>();
        text2 = AllBulletsLeft.GetComponent<Text>();
        text1.fontSize = 50;
        text1.fontStyle = FontStyle.Bold;
        text2.fontSize = 30;
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = MainCamera.GetComponent<RayShoot>().BulletsLeft.ToString();
        text2.text = MainCamera.GetComponent<RayShoot>().AllBulletsLeft.ToString();
    }
}
