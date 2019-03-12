using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawner : MonoBehaviour
{

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnDelay;
    public float spawnTime;
    public Vector2 center;
    public Vector2 size;

    // Use this for initialization
    void Start()
    {
        
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void SpawnObject()
    {
        Vector2 pos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));
        Instantiate(spawnee, pos, transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
