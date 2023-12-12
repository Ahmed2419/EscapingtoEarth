using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        maxEnemyHealth = 100;
        currentEnemyHealth = maxEnemyHealth;
        healthBar.SetMaxHealth(maxEnemyHealth); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TakeDamage(10);
        }
        if (currentEnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
