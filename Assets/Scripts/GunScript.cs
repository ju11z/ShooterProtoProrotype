using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform BulletSpawnPoint;
    public float shootForce=10;

    void Start()
    {
    }

    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.green);
        
    }

    public void Shoot()
    {
        //Debug.Log("¡ÛÏ!");
        GameObject bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = transform.up * shootForce;
    }
}
