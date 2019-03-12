using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnDelay;
    public float spawnTime;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
	}
	
	// Update is called once per frame
	void SpawnObject () {
        Instantiate(spawnee, transform.position, transform.rotation);
        if (stopSpawning){
            CancelInvoke("SpawnObject");
        }
	}
}
