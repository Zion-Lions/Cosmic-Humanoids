using UnityEngine;

using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Setup : NetworkBehaviour
{

    public float PositionLerpStep = 15f;
    public float RotationLerpStep = 15f;
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
            camera.SetActive(true);
        }
	}

    
    void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            CmdSendData(this.rigidbody.position, this.rigidbody.rotation);
        }
        if (!isServer && !isLocalPlayer)
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
