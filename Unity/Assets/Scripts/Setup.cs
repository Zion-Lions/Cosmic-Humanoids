using UnityEngine;

using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Setup : NetworkBehaviour
{

    public float PositionLerpStep = 5f;
    public float RotationLerpStep = 12f;
    public GameObject camera;
    [SyncVar]
    private Vector3 syncPosition;
    [SyncVar]
    private Quaternion syncRotation;

    private Rigidbody rigidbody;

	void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();

        if (isLocalPlayer)
        {
            this.GetComponent<RigidbodyFirstPersonController>().enabled = true;
            this.GetComponent<AmmoBoxScript>().enabled = true;
            this.GetComponent<Health>().enabled = true;

            camera.GetComponent<Camera>().enabled = true;
            camera.GetComponent<GUILayer>().enabled = true;
            camera.GetComponent<FlareLayer>().enabled = true;
            camera.GetComponent<MouseLook>().enabled = true;
            camera.GetComponent<AudioListener>().enabled = true;
            camera.GetComponent<AudioSource>().enabled = true;
            camera.GetComponent<RayShoot>().enabled = true;
            camera.GetComponent<SwitchWeapon>().enabled = true;
            camera.GetComponent<HideCursor>().enabled = true;
            camera.GetComponent<AimMultiplayer>().enabled = true;
            camera.GetComponent<PausedMenuMultiplayer>().enabled = true;

            camera.SetActive(true);
        }
	}

    
    void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            CmdSendData(this.rigidbody.position, this.rigidbody.rotation);
        }
        if (!isLocalPlayer)
        {
            Interpolate();
        }
    }

    private void Interpolate()
    {
        Vector3 newPos = Vector3.Lerp(this.rigidbody.position, syncPosition, Time.deltaTime * PositionLerpStep);
        rigidbody.MovePosition(newPos);

        Quaternion newRot = Quaternion.Lerp(this.rigidbody.rotation, syncRotation, Time.deltaTime * RotationLerpStep);
        rigidbody.MoveRotation(newRot);

    } 

    [Command]
    private void CmdSendData(Vector3 pos, Quaternion rot)
    {
        syncPosition = pos;
        syncRotation = rot;
    }
}
