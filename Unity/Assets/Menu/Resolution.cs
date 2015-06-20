using UnityEngine;
using System.Collections;

public class Resolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void fullscreen()
    {
        Screen.SetResolution(1920, 1200, true);
    }

    public void screen169()
    {
        Screen.SetResolution(1600, 900, true);
    }

    public void screen43()
    {
        Screen.SetResolution(1024, 768, true);
    }

    public void screen54()
    {
        Screen.SetResolution(1366, 768, true);
    }

}
