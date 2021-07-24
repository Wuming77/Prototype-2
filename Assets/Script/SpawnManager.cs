using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPerfabs;

    private float spawnRangeX = 20;
    private float spawnRangeZ = 30;

    private float startDelay = 3;
    private float spawnInterval = 2.0f;
    //public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int animalIndex = Random.Range(0, animalPerfabs.Length);
        Instantiate(animalPerfabs[animalIndex], spawnPos,
            animalPerfabs[animalIndex].transform.rotation);
    }
}
