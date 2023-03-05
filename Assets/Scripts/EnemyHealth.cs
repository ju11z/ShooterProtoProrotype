using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamagable
{
    public delegate void EnemyDeathHandler();
    public event EnemyDeathHandler OnEnemyDied;
    public int health { get; set; }

    public void BeDamaged(int damageApplied)
    {
        health-=damageApplied;

        if (health < 0)
        {
            Die();
        }
    }

    public void Die()
    {
        OnEnemyDied?.Invoke();

        Destroy(gameObject);

       
    }

    private void OnEnable()
    {
        OnEnemyDied+= GameObject.Find("GameLogic").GetComponent<GameLogic>().UpdateScore;
        OnEnemyDied += GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().ReduceEnemyCount;
    }

    private void OnDisable()
    {
        OnEnemyDied -= GameObject.Find("GameLogic").GetComponent<GameLogic>().UpdateScore;
        OnEnemyDied -= GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>().ReduceEnemyCount;
    }


    void Start()
    {
        health = 5;
    }

}
