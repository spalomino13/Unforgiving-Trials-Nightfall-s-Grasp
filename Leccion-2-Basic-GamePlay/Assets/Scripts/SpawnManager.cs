using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawRangeX = 20;
    private float spawPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    //public int animalIndex;
    // Start is called before the first frame update
    void Start()
    {
        // Invoke the SpawnRandomAnimal method repeatedly with a delay and interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space)) SpawnRandomAnimal();
    }

    void SpawnRandomAnimal()
    {
        // Generate a random index to select a random animal prefab from the array
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        // Generate a random spawn position within the specified range
        Vector3 spawnPos = new Vector3(Random.Range(-spawRangeX, spawRangeX), 0, spawPosZ);

        // Instantiate a random animal prefab at the generated spawn position
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);


    }
}
