using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTriggers : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    //public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Enemy"))
        {
            playerHealth == playerHealth - 100;
            
          
}
    }*/

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(10);
            Debug.Log("Ouch");
        }
    }
}
