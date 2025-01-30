using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingHPB : MonoBehaviour
{
    int maxHealth = 100;
    int currentHealth;

    public HealthBarScript HealthBar;



    private void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            TakeDamage(20);
            
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        HealthBar.SetHealth(currentHealth);
    }

}
