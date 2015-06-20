using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnerSurvival : MonoBehaviour
{
    public GameObject zombiePrefab; // prefab to spawn
    public int zombiesSpawned; // zombies spawned
    GameObject player; // player
    bool spawn;
    int minWait;
    int maxWait;
    int waitTime;
    int nb;
    private int minSpawn;
    private int maxSpawn;
    public List<GameObject> spawners;
    public int round;
    int n;

    // Use this for initialization
    void Start()
    {
        minWait = 1;
        maxWait = 5;
        minSpawn = 5;
        maxSpawn = 10;
        waitTime = Random.Range(minWait, maxWait);
        zombiesSpawned = 0;
        spawn = true;
        n = 0;
        round = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (nb > 0 && spawn)
        {
            Spawn();
        }

        if (zombiesSpawned == 0)
        {
            minSpawn *= 3 / 2;
            maxSpawn *= 3 / 2;
            nb = Random.Range(minSpawn, maxSpawn);
            round++;
        }
    }

    void Spawn()
    {
        Instantiate(zombiePrefab, spawners[n % spawners.Count].transform.position, spawners[n % spawners.Count].transform.rotation); // spawn at spawner location
        zombiesSpawned++;
        NewWaitTime();
        spawn = false;
        StartCoroutine(SetSpawn());
        nb--;
        n++;
    }

    IEnumerator SetSpawn()
    {
        yield return new WaitForSeconds(waitTime);
        spawn = true;
    }

    void NewWaitTime()
    {
        waitTime = Random.Range(minWait, maxWait);
    }
}
