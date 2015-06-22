using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PausedMenuMultiplayer : MonoBehaviour
{

    private bool isPaused;
    private bool isOption;
    float sliderValue = 1.0f;
    public GameObject Perso;
    public GameObject Camera;

    void Start()
    {
        isPaused = false;
        isOption = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("escape"))
        {
            GetComponent<AudioSource>().UnPause();
            isPaused = !isPaused;
        }

        if (isPaused || isOption)
        {
            //Arret du temps dans le jeu
            Time.timeScale = 0f;
            Cursor.visible = true;
            //Mise en pause des script
            Perso.GetComponent<RigidbodyFirstPersonController>().enabled = false;

            Camera.GetComponent<MouseLook>().enabled = false;
            //Camera.GetComponent<AudioListener>().enabled = false;
            Camera.GetComponent<AudioSource>().enabled = false;
            Camera.GetComponent<AimMultiplayer>().enabled = false;
            Camera.GetComponent<SwitchWeapon>().enabled = false;
            Camera.GetComponent<RayShoot>().enabled = false;


        }
        else
        {
            //Reviens à la normal
            Time.timeScale = 1.0f;

            Perso.GetComponent<RigidbodyFirstPersonController>().enabled = true;

            Camera.GetComponent<MouseLook>().enabled = true;
            Camera.GetComponent<AudioListener>().enabled = true;
            Camera.GetComponent<AudioSource>().enabled = true;
            Camera.GetComponent<AimMultiplayer>().enabled = true;
            Camera.GetComponent<SwitchWeapon>().enabled = true;
            Camera.GetComponent<RayShoot>().enabled = true;
        }
    }

    void OnGUI()
    {
        if (isPaused)
        {
            //Fais apparaitre les buttons
            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 120, 150, 70), "Continue"))
            {
                isPaused = false;
                isOption = false;
                Cursor.visible = false;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 40, 150, 70), "Option"))
            {
                isPaused = false;
                isOption = true;
                Cursor.visible = false;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 150, 70), "Main Menu"))
            {
                isPaused = !isPaused;
                Application.LoadLevel("MainMenu");
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 120, 150, 70), "Quit"))
            {
                Application.Quit();
            }
        }

        if (isOption)
        {
            GUI.Label(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 80, 150, 70), "Music Volume");
            sliderValue = GUI.HorizontalSlider(new Rect(Screen.width / 2 - 40, Screen.height / 2 - 40, 150, 70), sliderValue, 0.0f, 1.0f);
            AudioListener.volume = sliderValue;

            if (GUI.Button(new Rect(Screen.width / 2 - 40, Screen.height / 2 + 40, 150, 70), "Continue"))
            {
                isPaused = false;
                isOption = false;
                Cursor.visible = false;
            }
        }
    }
}
