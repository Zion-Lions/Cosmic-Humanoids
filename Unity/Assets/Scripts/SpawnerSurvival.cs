using UnityEngine;
using System.Collections;

public class SpawnerSurival : MonoBehaviour
{
    public GameObject zombiePrefab; // prefab to spawn
    int zombiesSpawned; // zombies spawned
    GameObject player; // player
    bool spawn;
    int minWait;
    int maxWait;
    int waitTime;
    private int minSpawn;
    private int maxSpawn;

    // Use this for initialization
    void Start()
    {
        minWait = 1;
        maxWait = 10;
        minSpawn = 5;
        maxSpawn = 10;
        waitTime = Random.Range(minWait, maxWait);
        zombiesSpawned = 0;
        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
            Spawn();
    }

    void Spawn()
    {
        Instantiate(zombiePrefab, transform.position, transform.rotation); // spawn at spawner location
        zombiesSpawned++;
        NewWaitTime();
        spawn = false;
        SetSpawn();
    }

    IEnumerator SetSpawn()
    {
        spawn = true;
        yield return new WaitForSeconds(waitTime);
    }

    void NewWaitTime()
    {
        waitTime = Random.Range(minWait, maxWait);
    }
}
