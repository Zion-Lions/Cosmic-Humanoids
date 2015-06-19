using UnityEngine;
using System.Collections;

public class RaysShootRobotKyle : MonoBehaviour
{

    public int BulletsPerClip;
    public int BulletsLeft;
    public float Damage;
    public float Range;
    public float Force;
    public int particleSpeed;

    public AudioClip ReloadSound;
    public AudioClip ShootSound;

    public ParticleEmitter MuzzleFlash;
    public ParticleEmitter hitParticles;

    public float ReloadTime;
    public float ShootTimer;
    public float ShootCooler;
    public float muzzleFlashCooler;
    public float muzzleFlashTimer;
    public float KeyCooler;
    public float KeyTimer;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

    public GameObject currentWeapon;

    
    void Start()
    {
        currentWeapon = GameObject.Find("SciFiGun");
        BulletsLeft = BulletsPerClip;
        hitParticles.emit = false;
    }

    void Update()
    {

        if (KeyTimer > 0)
        {
            KeyTimer -= Time.deltaTime;
        }

        if (KeyTimer < 0)
        {
            KeyTimer = 0;
        }

        /*if (muzzleFlashTimer > 0)
        {
            muzzleFlashTimer -= Time.deltaTime;
            MuzzleFlash.emit = false;
            Light1.SetActive(false);
            Light2.SetActive(false);
            Light3.SetActive(false);
        }*/

        if (muzzleFlashTimer < 0)
        {
            muzzleFlashTimer = 0;
        }

        if (ShootTimer > 0)
        {
            ShootTimer -= Time.deltaTime;
        }

        if (ShootTimer < 0)
        {
            ShootTimer = 0;
        }
    }

    void MuzzleFlashShow()
    {
        MuzzleFlash.emit = false;
        Light1.SetActive(false);
        Light2.SetActive(false);
        Light3.SetActive(false);

        MuzzleFlash.transform.localRotation = Quaternion.AngleAxis(Random.value * 360 * particleSpeed, Vector3.forward);

        MuzzleFlash.emit = true;
        Light1.SetActive(true);
        Light2.SetActive(true);
        Light3.SetActive(true);
    }

    public void RayShot()
    {
        if (ShootTimer <= 0)
        {
            RaycastHit hit;
            /*if (Input.GetKey(KeyCode.Mouse1))
            {
                currentWeapon.GetComponent<Animation>().Play("Recul2");
            }
            else
            {
                currentWeapon.GetComponent<Animation>().Play("Recul1");
            }*/

            Vector3 DirectionRay = transform.TransformDirection(Vector3.forward);
            Debug.DrawRay(transform.position, DirectionRay*Range, Color.yellow);

            if (Physics.Raycast(transform.position, DirectionRay, out hit, Range))
            {
                if (hit.collider.gameObject.tag == "Player")
                {


                    hitParticles.transform.position = hit.point;
                    hitParticles.transform.localRotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);

                    hitParticles.Emit();


                    hit.rigidbody.AddForceAtPosition(DirectionRay*Force, hit.point);
                    hit.collider.gameObject.GetComponent<Health>().ApplyDamage((int) Damage);

                    ShootTimer = ShootCooler;
                    KeyTimer = KeyCooler;
                }
            }

            BulletsLeft--;

            if (BulletsLeft < 0)
            {
                BulletsLeft = 0;
            }

            if (BulletsLeft == 0)
            {
                Reload();
            }
        }
    }

    void PlayShootAudio()
    {
        GetComponent<AudioSource>().PlayOneShot(ShootSound);
    }

    void PlayReloadAudio()
    {
        GetComponent<AudioSource>().PlayOneShot(ReloadSound);
    }

    void Reload()
    {
        StartCoroutine(ReloadSpeed());
    }

    IEnumerator ReloadSpeed()
    {
        //currentWeapon.GetComponent<Animation>().Play("Reload");
        //PlayReloadAudio();
        yield return new WaitForSeconds(ReloadTime);

        BulletsLeft = BulletsPerClip;
    }
}
