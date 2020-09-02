using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject enemy;

    public float xPositionLimit;
    public float spawnRate;

    void Start(){
        startSpawning();
    }

   void spawnSpike() {

        float randomX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

    void startSpawning() {
        InvokeRepeating("spawnSpike", 1f, spawnRate);
    }

    public void stopSpawning() {
        CancelInvoke("spawnSpike");
    }
}
