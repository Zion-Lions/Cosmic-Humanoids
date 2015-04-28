using UnityEngine;
using System.Collections;

public class SwitchWeapon : MonoBehaviour
{

    public RayShoot ScriptRayShoot;
    public GameObject M4A1;
    public GameObject M9;

	// Use this for initialization
	void Start ()
	{
        carChange();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2) && M4A1.activeSelf && !M9.activeSelf)
        {
            ScriptRayShoot.currentWeapon.GetComponent<Animation>().Play("SwitchOff");
            StartCoroutine(Wait());
            ScriptRayShoot.currentWeapon.SetActive(false);

            M9.GetComponent<Animation>().Play("SwitchOn");
            StartCoroutine(Wait());
            M9.SetActive(true);

            ScriptRayShoot.currentWeapon = M9;
            carChange();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && !M4A1.activeSelf && M9.activeSelf)
        {
            ScriptRayShoot.currentWeapon.GetComponent<Animation>().Play("SwitchOff");
            StartCoroutine(Wait());
            ScriptRayShoot.currentWeapon.SetActive(false);

            M4A1.GetComponent<Animation>().Play("SwitchOn");
            StartCoroutine(Wait());
            M4A1.SetActive(true);

            ScriptRayShoot.currentWeapon = M4A1;
            carChange();
        }
	}

    void carChange()
    {
        GameObject currentWeapon = ScriptRayShoot.currentWeapon;
        ScriptRayShoot.AllBulletsLeft = currentWeapon.GetComponent<Weapon>().AllBulletsLeft;
        ScriptRayShoot.BulletsPerClip = currentWeapon.GetComponent<Weapon>().BulletsPerClip;
        ScriptRayShoot.BulletsLeft = currentWeapon.GetComponent<Weapon>().BulletsLeft;
        ScriptRayShoot.Damage = currentWeapon.GetComponent<Weapon>().Damage;
        ScriptRayShoot.Range = currentWeapon.GetComponent<Weapon>().Range;
        ScriptRayShoot.Force = currentWeapon.GetComponent<Weapon>().Force;
        ScriptRayShoot.particleSpeed = currentWeapon.GetComponent<Weapon>().particleSpeed;
        ScriptRayShoot.ReloadTime = currentWeapon.GetComponent<Weapon>().ReloadTime;
        ScriptRayShoot.ShootTimer = currentWeapon.GetComponent<Weapon>().ShootTimer;
        ScriptRayShoot.ShootCooler = currentWeapon.GetComponent<Weapon>().ShootCooler;
        ScriptRayShoot.muzzleFlashCooler = currentWeapon.GetComponent<Weapon>().muzzleFlashCooler;
        ScriptRayShoot.muzzleFlashTimer = currentWeapon.GetComponent<Weapon>().muzzleFlashTimer;
        ScriptRayShoot.KeyCooler = currentWeapon.GetComponent<Weapon>().KeyCooler;
        ScriptRayShoot.KeyTimer = currentWeapon.GetComponent<Weapon>().KeyTimer;
        ScriptRayShoot.MuzzleFlash = currentWeapon.GetComponent<Weapon>().MuzzleFlash;
        ScriptRayShoot.ReloadSound = currentWeapon.GetComponent<Weapon>().ReloadSound;
        ScriptRayShoot.ShootSound = currentWeapon.GetComponent<Weapon>().ShootSound;
        ScriptRayShoot.Light1 = currentWeapon.GetComponent<Weapon>().Light1;
        ScriptRayShoot.Light2 = currentWeapon.GetComponent<Weapon>().Light2;
        ScriptRayShoot.Light3 = currentWeapon.GetComponent<Weapon>().Light3;
        ScriptRayShoot.MuzzleFlash.emit = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
