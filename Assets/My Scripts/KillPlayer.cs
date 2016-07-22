using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
    public GameObject playerDeathEffect;

    public LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
         if (other.tag == "Player")
         {
            Destroy(other.gameObject);
            Instantiate(playerDeathEffect, other.transform.position, other.transform.rotation);

            levelManager.RespawnPlayer();
        }
    }
}
    