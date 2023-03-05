using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamagable, IHealable
{
    public int health { get; set; }

    public delegate void PlayerHealthHandler(int health);
    public event PlayerHealthHandler OnPlayerDamaged;
    public event PlayerHealthHandler OnPlayerDied;
    public event PlayerHealthHandler OnPlayerHealed;

    private void OnEnable()
    {
        OnPlayerDamaged += GameObject.Find("GameLogic").GetComponent<GameLogic>().UpdateHealth;
        OnPlayerDied += GameObject.Find("UIManager").GetComponent<UIManager>().ShowDeathScreen;
        OnPlayerHealed+= GameObject.Find("GameLogic").GetComponent<GameLogic>().UpdateHealth;
        
    }

    private void OnDisable()
    {
        OnPlayerDamaged -= GameObject.Find("GameLogic").GetComponent<GameLogic>().UpdateHealth;
        OnPlayerDied -= GameObject.Find("UIManager").GetComponent<UIManager>().ShowDeathScreen;
        OnPlayerHealed -= GameObject.Find("GameLogic").GetComponent<GameLogic>().UpdateHealth;
       
    }

    
    public void BeDamaged(int damageApllied)
    {
        health-=damageApllied;
        OnPlayerDamaged?.Invoke(health);
        //Debug.Log("Player is damaged!!!");

        if (health < 0)
        {
            Die();
        }
    }

    public void Die()
    {
        //Debug.Log("Player is dead!!!");
        OnPlayerDied?.Invoke(health);
    }


    void Start()
    {
        health = 10;
    }

    void Update()
    {
        
    }

    public void BeHealed(int healAbility)
    {
        health += healAbility;
        OnPlayerHealed?.Invoke(health);
        Debug.Log("Attemp to heal from PlayerHealth");
    }
}
