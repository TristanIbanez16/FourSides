using UnityEngine;
using System.Collections;

public class BulletForce : MonoBehaviour {

    // the public float magnitude for the speed of the bullet
	public float magnitude = 1.0f;

    private int attackDamage = 15;

    public GameObject bulletImpactEffect;
    public GameObject enemyDeathEffect;
    GameObject TankEnemy;
    TankHealth tankHealth;

    // Use this for initialization
    void Start () 
	{
		GetComponent<Rigidbody2D> ().AddForce (magnitude * transform.right);
		Destroy (gameObject, 5);
        TankEnemy = GameObject.Find("Tank Enemy");
        tankHealth = TankEnemy.GetComponent<TankHealth>();
    }
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) 
	{
        // if the object that the bullet hits has this tag, the object will be destroyed and then spawn a prefab
        if(other.tag == "Enemy")
        {
            Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);

            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if(other.tag == "Level")
        {
            // if the bullet hits a wall or nothing it will destory itself and spawn a prefab
            Instantiate(bulletImpactEffect, transform.position, transform.rotation);
            Destroy (gameObject);
        }

        if (other.tag == "Enemy Tank")
        {
            Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);

            Destroy(gameObject);
            // If the player has health to lose...
            if (tankHealth.currentHealth > 0)
            {
                // ... damage the player.
                tankHealth.TakeDamage(attackDamage);
            }
        }
    }
}
