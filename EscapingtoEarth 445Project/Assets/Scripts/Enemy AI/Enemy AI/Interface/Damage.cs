using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Damage 
{
    void Damage(float damageAmount);
    void Die();

    float MaxHealt { get; set; }
    float CurrentHealth { get; set; }
}
