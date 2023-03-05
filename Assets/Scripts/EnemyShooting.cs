using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour, ICanShoot
{
    public GameObject Gun { get; set; }

    public float secondsBetweenSpawn=5;
    public float elapsedTime = 0.0f;


    void Start()
    {
        Gun = MyExtensions.FindChildWithTag(gameObject, "Gun");
        if (Gun != null)
        {
            //Debug.Log("Enemy gun detected!");
        }
        else
        {
            //Debug.Log("No enemy gun :(");
        }


    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            Gun.GetComponent<GunScript>().Shoot();
        }
    }

    public void Shoot()
    {
        Gun.GetComponent<GunScript>().Shoot();
    }
}
