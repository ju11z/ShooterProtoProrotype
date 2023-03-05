using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    public int health { get; set; }

    public void BeDamaged(int damageAmount);

    public void Die();


}
