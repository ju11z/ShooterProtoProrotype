using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamaging : MonoBehaviour,ICanDamage
{
    public int damageAbility = 1;

    public void ApplyDamage(IDamagable damagable)
    {
        damagable.BeDamaged(damageAbility);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<IDamagable>(out IDamagable damagable))
        {
            ApplyDamage(damagable);
            Destroy(gameObject);
        }
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("FloorLayer"))
        {
            Destroy(gameObject);
        }
    }

    
}
