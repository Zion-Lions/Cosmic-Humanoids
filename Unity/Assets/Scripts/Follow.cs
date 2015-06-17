using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public Transform Target;
	public NavMeshAgent agent;
	float f;
	float rythme = 0f;
	GUIText temp;
	public GameObject[] Spawn;
	Animator anim;
	int t = 0;
	bool opening = false;
	bool closed = true;
	GameObject Door;
	float timer = 200f;  
	bool playerInRange;
	int attackDamage = 1;
	float Dist;
	float maxDist = 2f;
	GameObject player;
	Animator attack;
	public bool activated;
	Animation marche;


	// Use this for initialization
	void Start () {
		agent = gameObject.GetComponent<NavMeshAgent>();
		f = agent.speed;
	}
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag("Player");
		Target = player.transform;
		agent.SetDestination(Target.position);
	}
}
