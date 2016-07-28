using UnityEngine;
using System.Collections;

public class TankHealth : MonoBehaviour {

    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth;                   // The current health the enemy has.
 

    int randomNum;

    bool isDead;                                // Whether the enemy is dead.

    void Awake()
    {
        // Setting up the references.

        GameObject.Find("BloodParticle");

        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;
    }


    public void TakeDamage(int amount)
    {
        // If the enemy is dead...
        if (isDead)
            // ... no need to take damage so exit the function.
            return;

        // Reduce the current health by the amount of damage sustained.
        currentHealth -= amount;

        // If the current health is less than or equal to zero...
        if (currentHealth <= 0)
        {
            // ... the enemy is dead.
            Death();
        }
    }


    void Death()
    {

        Destroy(gameObject);

    }
}
