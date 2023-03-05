using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICanDamage 
{
    public void ApplyDamage(IDamagable damagable);
}
