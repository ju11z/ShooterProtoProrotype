using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float secondsBetweenSpawn = 2;
    public float elapsedTime = 0.0f;

    public int limit = 3;
    public int count;


    void Start()
    {
        count = 0;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn && count<limit)
        {
            elapsedTime = 0;
            SpawnEnemy();
        }
    }

    public void ReduceEnemyCount()
    {
        count--;
    }

    public void SpawnEnemy()
    {
        count++;
        GameLogic.Instantiate(enemyPrefab);
    }
}
