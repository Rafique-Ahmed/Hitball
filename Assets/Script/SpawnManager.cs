using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obsPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 15;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnobs",startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnobs() {
          // Generate Ramdom objects
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
            int obsIndex = Random.Range(0, obsPrefabs.Length);
            Instantiate(obsPrefabs[obsIndex], spawnPos, obsPrefabs[obsIndex].transform.rotation);
    }
}
