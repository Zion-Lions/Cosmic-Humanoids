using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour
{
    public int BulletsPerClip;
    public int BulletsLeft;
    public int AllBulletsLeft;
    public float Damage;
    public float Range;
    public float Force;
    public int particleSpeed;

    public float ReloadTime;
    public float ShootTimer;
    public float ShootCooler;
    public float muzzleFlashCooler;
    public float muzzleFlashTimer;
    public float KeyCooler;
    public float KeyTimer;

    public ParticleEmitter MuzzleFlash;

    public AudioClip ReloadSound;
    public AudioClip ShootSound;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

	// Use this for initialization
	void Start ()
	{
	    BulletsLeft = BulletsPerClip;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}
