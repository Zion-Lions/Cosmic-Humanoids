using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

public class SoundControl : MonoBehaviour {
	public AudioClip song1;
	public AudioClip song2;
	public AudioClip song3;
	public AudioClip song4;
	public AudioClip song5;
	public AudioClip interlude;


	void Start()
	{
				if (Application.loadedLevelName == "MainMenu") {
			GetComponent<AudioSource>().PlayOneShot(interlude);
				} else if (Application.loadedLevelName == "FirstGame") {
						GetComponent<AudioSource> ().PlayOneShot (song2);
				} else if (Application.loadedLevelName == "Game") {
						GetComponent<AudioSource> ().PlayOneShot (song3);
				} else if (Application.loadedLevelName == "MazeGenerator") {
						GetComponent<AudioSource> ().PlayOneShot (song5);
				}
				else if (Application.loadedLevelName == "Multijoueur") {
						GetComponent<AudioSource>().PlayOneShot(song1);
				}
				else if (Application.loadedLevelName == "TheEnd") {
						GetComponent<AudioSource>().PlayOneShot(song4);
				}
	}

	void Update()
	{

	}

	public void Next()
	{
		}


	public void Play()
	{

		}

	public void Pause()
	{

	}

	public void Stop()
	{

	}
}
