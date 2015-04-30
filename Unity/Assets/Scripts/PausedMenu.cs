using UnityEngine;
using System.Collections;

public class PausedMenu : MonoBehaviour
{

    private bool isPaused;
	public GameObject Perso;
	public GameObject Camera;

	void Start()
	{
	    isPaused = false;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("escape"))
        {
			GetComponent<AudioSource>().UnPause();
            isPaused = !isPaused;
        }

        if (isPaused)
		{
			//Arret du temps dans le jeu
			Time.timeScale = 0f;
			Cursor.visible = true;
			//Mise en pause des script
			Perso.GetComponent<MouseLook>().enabled = false;
			Perso.GetComponent<CharacterMotor>().enabled = false;
			Perso.GetComponent<FPSInputController>().enabled = false;

            Camera.GetComponent<MouseLook>().enabled = false;
            Camera.GetComponent<AudioListener>().enabled = false;
            Camera.GetComponent<AudioSource>().enabled = false;
            Camera.GetComponent<Aim>().enabled = false;
            Camera.GetComponent<SwitchWeapon>().enabled = false;
            Camera.GetComponent<RayShoot>().enabled = false;
				

		}
		else
        {
			//Reviens à la normal
			Time.timeScale = 1.0f;
            
            Perso.GetComponent<MouseLook>().enabled = true;
            Perso.GetComponent<CharacterMotor>().enabled = true;
            Perso.GetComponent<FPSInputController>().enabled = true;

            Camera.GetComponent<MouseLook>().enabled = true;
            Camera.GetComponent<AudioListener>().enabled = true;
            Camera.GetComponent<AudioSource>().enabled = true;
            Camera.GetComponent<Aim>().enabled = true;
            Camera.GetComponent<SwitchWeapon>().enabled = true;
            Camera.GetComponent<RayShoot>().enabled = true;
		}
    }

    void OnGUI()
    {
        if (isPaused)
        {
            //Fais apparaitre les buttons
            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 40, 80, 35), "Continue"))
			{
                isPaused = false;
				Cursor.visible = false;
			}

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2, 80, 35), "Main Menu"))
            {
                Application.LoadLevel("MainMenu");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 35), "Quit"))
            {
                Application.Quit();
            }
        }
    }
}
