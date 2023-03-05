using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour, ICanShoot
{
    public GameObject Gun { get; set; }


    public void Shoot()
    {
        Gun.GetComponent<GunScript>().Shoot();
    }

    void Start()
    {
        Gun = MyExtensions.FindChildWithTag(gameObject, "Gun");
        if (Gun != null)
        {
            //Debug.Log("Gun detected!");
        }
        else
        {
            //Debug.Log("No gun :(");
        }
        
        
    }

    void Update()
    {
    if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    
}
