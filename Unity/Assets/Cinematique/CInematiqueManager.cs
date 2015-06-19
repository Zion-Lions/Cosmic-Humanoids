using UnityEngine;
using System.Collections;

public class CInematiqueManager : MonoBehaviour {

    void Update()
    {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown("p"))
        {
            Application.LoadLevel("FirstGame");
        }
    }
}
