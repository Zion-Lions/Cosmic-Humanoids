using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{

    public int health;


    void Start()
    {
        health = Random.Range(10, 150);
    }

    void Update()
    {

    }

    public void ApplyDamage(int Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            GameObject.Find("Spawners").GetComponent<SpawnerSurvival>().zombiesSpawned--;
            Destroy(gameObject);
        }
    }
}