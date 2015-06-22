using UnityEngine;

using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;

public class Setup : NetworkBehaviour {

    public RigidbodyFirstPersonController script;
	void Start () {
	
             
        if(!isLocalPlayer)
        {
          
           
            //GameObject.Find("HUDCanvas").SetActive(false);
             GetComponent<RigidbodyFirstPersonController>().enabled = false;
            

            
            Debug.Log("OK");
           
        }
	}
	
	
	
	
}
