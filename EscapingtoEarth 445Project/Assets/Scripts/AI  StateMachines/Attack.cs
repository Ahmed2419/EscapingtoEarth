using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : State
{
    public Attack attackState;


    public override State RunCurrentState()
    {
      
        Debug.Log("I have attacked");

        return this;
    }
  /*  private void Chase()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }*/
}
