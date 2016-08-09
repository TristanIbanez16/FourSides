using UnityEngine;
using System.Collections;

public class PickupManager : MonoBehaviour {

    GameObject bulletSpawnPoint;
    Shooter rateOfFire;

    private float timer;

    void Start()
    {
        bulletSpawnPoint = GameObject.Find("Bullet Spawn Point");
        rateOfFire = bulletSpawnPoint.GetComponent<Shooter>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log("Time: " + timer);


        if (timer > 5f)
        {
            rateOfFire.fireRate = 0.35f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if the gameobject has the tag "Pick Up", disable the game object.
        if (other.gameObject.CompareTag("Pickup"))
        {
            timer = 0f;
            other.gameObject.SetActive(false);
            rateOfFire.fireRate = 0.2f;


        }
    }
}
