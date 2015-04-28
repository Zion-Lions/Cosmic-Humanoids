using UnityEngine;
using System.Collections;

public class GunMovement : MonoBehaviour
{

    public float MoveAmount = 1;
    public float MoveSpeed = 2;
    public GameObject Gun;
    public float MoveOnX;
    public float MoveOnY;
    public Vector3 defaultPos;
    public Vector3 NewGunPos;
    public bool ONOFF = false;

	// Use this for initialization
	void Start ()
	{
	    defaultPos = transform.localPosition;
	    ONOFF = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (ONOFF)
	    {
            MoveOnX = Input.GetAxis("Mouse X") * Time.deltaTime * MoveAmount;
            MoveOnY = Input.GetAxis("Mouse Y") * Time.deltaTime * MoveAmount;
            NewGunPos = new Vector3(defaultPos.x + MoveOnX, defaultPos.y + MoveOnY, defaultPos.z);
            Gun.transform.localPosition = Vector3.Lerp(Gun.transform.localPosition, NewGunPos, MoveSpeed * Time.deltaTime);
	    }
	    else
	    {
	        ONOFF = false;
            Gun.transform.localPosition = Vector3.Lerp(Gun.transform.localPosition, defaultPos, MoveSpeed * Time.deltaTime);
	    }
	    
	}
}
