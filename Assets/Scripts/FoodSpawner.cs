using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodPrefab;

    public float secondsBetweenSpawn = 2;
    public float elapsedTime = 0.0f;

    public int limit = 5;
    public int count;
    void Start()
    {
        count = 0;
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn && count < limit)
        {
            elapsedTime = 0;
            SpawnFood();
        }
    }

    public void ReduceEnemyCount()
    {
        count--;
    }

    public void SpawnFood()
    {
        Debug.Log("Food spawn?");

        int x = Random.Range(-10, 10);
        int z = Random.Range(-10, 10);
        int y = 3;
        Vector3 position = new Vector3(x, y, z);
        GameObject food = GameLogic.Instantiate(foodPrefab, position, Quaternion.identity);
        
        count++;

    }
}
