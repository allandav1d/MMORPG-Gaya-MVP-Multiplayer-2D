﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStats : CharacterStats
{ 
    public override void Die()
    {
        base.Die();
        //add ragdoll effect/ death animation
        Destroy(gameObject);
    }

}
