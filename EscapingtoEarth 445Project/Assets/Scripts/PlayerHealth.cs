using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerHealth : MonoBehaviour
{ // reference to script: https://www.youtube.com/watch?v=BLfNP4Sc_iA&t=378s
    // reference to script: https://www.youtube.com/watch?v=ZfRbuOCAeE8
    public static event Action OnPlayerDeath;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(20);
        }
        
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("You're Dead");
            OnPlayerDeath?.Invoke();
            Destroy(gameObject);
        }
    }
   



   public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);

        // if (currentHealth <= 0)
        //{
        //    currentHealth = 0;
        //    Debug.Log("You're Dead");
        //    OnPlayerDeath?.Invoke();
        //}
    }
     void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "Projectile"){
            TakeDamage(10);
        }
     }
}
