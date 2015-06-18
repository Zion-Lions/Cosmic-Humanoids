using UnityEngine;
using System.Collections;

public class AmmoBoxScript : MonoBehaviour
{
    public GameObject MainCamera;
    private GameObject currentWeapon;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "AmmoBox")
        {
            currentWeapon = MainCamera.GetComponent<RayShoot>().currentWeapon;

            MainCamera.GetComponent<RayShoot>().AllBulletsLeft += MainCamera.GetComponent<RayShoot>().BulletsPerClip;
            currentWeapon.GetComponent<Weapon>().AllBulletsLeft += currentWeapon.GetComponent<Weapon>().BulletsPerClip;

            Destroy(collision.gameObject);
        }
        else
        {
            Debug.Log("collide (name) : " + collision.GetComponent<Collider>().gameObject.name);
            Debug.Log("collide (tag) : " + collision.GetComponent<Collider>().gameObject.tag);
            
        }
    }
}
