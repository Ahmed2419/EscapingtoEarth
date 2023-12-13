using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{



    public bool PlayerIsWithinRange;
    public Attack attackState;


    public override State RunCurrentState()
    {
        if (PlayerIsWithinRange)
        {
            return attackState;
        }
        else
        {
        return this;
        }
        
    }
}
