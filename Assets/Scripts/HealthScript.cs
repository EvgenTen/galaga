﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthScript : MonoBehaviour
{
    public int hp = 10;
    public bool isEnemy = true;
   


     public void Start()
     {
        
     }
    public void Damage(int damageCount)
    {
        hp -= damageCount;

        
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShotScript shot = collision.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {
              
                Damage(shot.damage);

                Destroy(shot.gameObject);
            }
        }

    }

    public int health
    {
        get
        {
            return hp;
        }
    }
}
