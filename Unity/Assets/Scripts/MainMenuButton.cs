using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour 
{
	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	public void StartGame()
	{
        Application.LoadLevel("FirstGame");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

    public void settingGame()
    {

    }

    public void website()
    {
        Application.OpenURL("http://www.google.com");
    }

}
