using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;
    public GameObject[] enemies;
    public float minTimeBtwSpawns;
    public float maxTimeBtwSpawns;
    public bool canSpawn;
    public float spawnTime;
   // public int enemiesInRoom;
    //public bool spawnDone;
   // public GameObject spawnerDoneGameObject;

private void Start()
{
    Invoke("SpawnEnemy", 0.5f);
}

void SpawnEnemy()
{
    index = Random.Range(0, spawnPoints.Length);
    currentPoint = spawnPoints[index];
    float timeBtwSpawns = Random.Range(minTimeBtwSpawns, maxTimeBtwSpawns);

    if (canSpawn)
    {
        Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
        //enemiesInRoom++;
    }

    Invoke("SpawnEnemy", timeBtwSpawns);
/*
    if (spawnDone)
    {
        spawnerDoneGameObject.setActive(true);
    } */
}
}
