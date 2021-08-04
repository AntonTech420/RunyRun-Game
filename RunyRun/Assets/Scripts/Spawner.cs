using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ball;
      public float spawnRate = 1.0f;
    public float spawnDelay = 1.5f;
    float randomX;
    Vector3 whereToSpawn;

    // Update is called once per frame
    void Update()
    {
        spawnRate -= Time.deltaTime;
        if (spawnRate <= 0)
        {
            spawnRate = spawnDelay;
            randomX = Random.Range(-25.5f, -16.5f);
            whereToSpawn = new Vector3(randomX, transform.position.y, transform.position.z);
            Instantiate(ball, whereToSpawn, Quaternion.identity);
        }
    }
}

