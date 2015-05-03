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
	bool pause;
	int n;
	Time t;

	// Use this for initialization
	void Start () {
		pause = true;
		GetComponent<AudioSource> ().Stop ();
		AudioListener.pause = true;
		Play ();
		if (GetComponent<AudioSource> ().mute) {
			GetComponent<AudioSource> ().PlayOneShot (song1);
			GetComponent<AudioSource>().mute = false;
			Pause();
				}
		n = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play()
	{
		AudioListener.pause = false;
		if(GetComponent<AudioSource>().mute)
			GetComponent<AudioSource> ().Play();
	}

	public void Pause()
	{
		if (pause) {
			AudioListener.pause = true;;
				}else
			AudioListener.pause = false;
		pause = !pause;
	}

	public void Next()
	{
		GetComponent<AudioSource> ().Stop ();
		AudioListener.pause = true;
		pause = true;
		n++;
		AudioListener.pause = false;
		GetComponent<AudioSource> ().PlayOneShot (songtoplay (n));
	}

	public void Stop()
	{
		AudioListener.pause = true;
		pause = true;
		GetComponent<AudioSource> ().Stop ();
	}

	AudioClip songtoplay(int i)
	{
		switch (i)
		{
		case(1):
			return song1;
		case(2):
			return song2;
		case(3):
			return song3;
		case(4):
			return song4;
		case(5):
			return song5;
		default:
			n = 1;
			return song1;
		}
	}

	public void Volplus()
	{
		GetComponent<AudioSource> ().volume++;
	}

	public void Volmoins()
	{
		GetComponent<AudioSource> ().volume--;
	}
}
