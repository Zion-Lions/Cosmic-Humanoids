using UnityEngine;
using System.Collections;

public class SpawnEnnemi : MonoBehaviour {
	public GameObject ennemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "Perso complet") {
						Instantiate (ennemy, this.transform.position, this.transform.rotation);
						GetComponent<BoxCollider> ().enabled = false;
				}
	}
}