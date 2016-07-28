﻿using UnityEngine;
using System.Collections;

public class ShotDamage : MonoBehaviour {

    private int attackDamage = 15;

    GameObject TankEnemy;
    TankHealth tankHealth;

	// Use this for initialization
	void Start ()
    {
        TankEnemy = GameObject.Find("Tank Enemy");
        tankHealth = TankEnemy.GetComponent<TankHealth>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider2D other)
    {
        // ... the player is in range.
        Attack();
    }

    void Attack()
    {
        // If the player has health to lose...
        if (tankHealth.currentHealth > 0)
        {
            // ... damage the player.
            tankHealth.TakeDamage(attackDamage);
        }
    }
}
