using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanShoot 
{
    public GameObject Gun { get; set; }

    public void Shoot();
    
}
