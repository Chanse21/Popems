using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BalloonSpawner : MonoBehaviour
{

    public GameObject BalloonPrefab; // Drag your balloon prefab here

    public float spawnInterval = 2f; // Time between spawns

    public Vector3 spawnArea = new Vector3(10, 0, 10); // Area where balloons can spawn



    void Start()

    {

        // Start spawning repeatedly

        InvokeRepeating("SpawnBalloon", 0f, spawnInterval);

    }



    void SpawnBalloon()

    {

        // Random position within the spawn area

        float x = Random.Range(-spawnArea.x / 2, spawnArea.x / 2);

        float y = Random.Range(0, spawnArea.y);

        float z = Random.Range(-spawnArea.z / 2, spawnArea.z / 2);



        Vector3 spawnPosition = transform.position + new Vector3(x, y, z);



        // Instantiate balloon

        Instantiate(BalloonPrefab, spawnPosition, Quaternion.identity);

    }

}


