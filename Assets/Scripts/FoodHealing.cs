using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodHealing : MonoBehaviour, ICanHeal
{
    public int healAbility;

    public void Start()
    {
        healAbility = 2;
    }

    public void Heal(IHealable healable)
    {
        healable.BeHealed(healAbility);
        //Debug.Log("Attemp to heal from FoodHealing");
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Food collide with smth");
        if (collision.gameObject.TryGetComponent<IHealable>(out IHealable ph))
        {
            Heal(ph);
            Destroy(gameObject);
        }
    }
}
