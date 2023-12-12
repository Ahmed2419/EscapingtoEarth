using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int currentEnemyHealth;
    public int maxEnemyHealth;
    public float enemySpeed;
    public float enemyDamage;

    public HealthBar healthBar;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player Bullet"))
        {
            TakeDamage(20);
        }

        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(10);
            Debug.Log("Ouch");
        }
    }
    public void TakeDamage(int damage)
    {
        currentEnemyHealth -= damage;
        healthBar.SetHealth(currentEnemyHealth);
    }
}
