using UnityEngine;
using System.Collections;

public class CInematiqueManager : MonoBehaviour
{

    public MovieTexture test;

    void Start()
    {
        test = (MovieTexture) GetComponent<Renderer>().material.mainTexture;
    }

    void Update()
    {
        test.Play();

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown("p"))
        {
            Application.LoadLevel("Game");
        }
    }
}
