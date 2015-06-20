using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDSurvival : MonoBehaviour {

    private GameObject MainCamera;
    private GameObject Spawners;
    public GameObject BulletsLeft;
    public GameObject AllBulletsLeft;
    public GameObject ZombiesLeft;
    public GameObject Round;
    private Text text1;
    private Text text2;
    private Text text3;
    private Text text4;
    // Use this for initialization
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera");
        Spawners = GameObject.Find("Spawners");
        text1 = BulletsLeft.GetComponent<Text>();
        text2 = AllBulletsLeft.GetComponent<Text>();
        text3 = ZombiesLeft.GetComponent<Text>();
        text4 = Round.GetComponent<Text>();
        text1.fontSize = 50;
        text1.fontStyle = FontStyle.Bold;
        text2.fontSize = 30;
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = MainCamera.GetComponent<RayShoot>().BulletsLeft.ToString();
        text2.text = MainCamera.GetComponent<RayShoot>().AllBulletsLeft.ToString();
        text3.text = "Zombies Left: " + Spawners.GetComponent<SpawnerSurvival>().zombiesSpawned.ToString();
        text4.text = "Round: " + Spawners.GetComponent<SpawnerSurvival>().round.ToString();
    }
}
