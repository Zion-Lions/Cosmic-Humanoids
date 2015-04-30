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
	int n;
	Time t;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().PlayOneShot (song1);
		n = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play()
	{
		GetComponent<AudioSource> ().Play();
	}

	public void Pause()
	{
		GetComponent<AudioSource> ().Pause();
	}

	public void Next()
	{
		GetComponent<AudioSource> ().Stop ();
		n++;
		GetComponent<AudioSource> ().PlayOneShot (songtoplay (n));
	}

	public void Stop()
	{
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
}
