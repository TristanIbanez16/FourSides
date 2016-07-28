using UnityEngine;
using System.Collections;

public class EnemyBulletForce : MonoBehaviour {

    // the public float magnitude for the speed of the bullet
    public float magnitude = 1.0f;

    public GameObject bulletImpactEffect;
    public GameObject enemyDeathEffect;

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(magnitude * transform.right);
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        // if the object that the bullet hits has this tag, the object will be destroyed and then spawn a prefab
        if (other.tag == "Player")
        {
            Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);
            Instantiate(bulletImpactEffect, transform.position, transform.rotation);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.tag == "Level")
        {
            // if the bullet hits a wall or nothing it will destory itself and spawn a prefab
            Instantiate(bulletImpactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}
