using UnityEngine;
using System.Collections;

public class NavMeshAISurvival : MonoBehaviour {

    Transform targetToLookAt;
    Vector3 v;



    void Start()
    {
        targetToLookAt = GameObject.Find("MAX").transform;
    }


    void Update()
    {
        if (Vector3.Distance(transform.position, targetToLookAt.transform.position) <= 5f)
        {
            GetComponent<Animation>().Stop();
            GetComponent<NavMeshAgent>().speed = 0f;
            transform.LookAt(targetToLookAt.position);
            gameObject.GetComponent<RaysShootRobotKyle>().RayShot();
        }

        else
        {
            GetComponent<NavMeshAgent>().destination = targetToLookAt.position;
            GetComponent<Animation>().Play("Robot_animation");
            GetComponent<NavMeshAgent>().speed = 2f;
        }
    }
}
