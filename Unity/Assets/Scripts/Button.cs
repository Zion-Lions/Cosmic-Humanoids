using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public enum ButtonTypes { Play, Pause, Stop, Next };
	public ButtonTypes type;
	public SoundControl sound;

	// Use this for initialization
	void Start () {
		OnMouseDown ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		switch (type) 
		{
		case ButtonTypes.Play:
			sound.Play();
			break;
		case ButtonTypes.Stop:
			sound.Stop();
			break;
		case ButtonTypes.Pause:
			sound.Pause();
			break;
		case ButtonTypes.Next:
			sound.Next();
			break;
		}
	}
}
