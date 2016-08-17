using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip enemyShoot;

    public GameObject BulletPrefab;

    public float fireRate = 1.0f;
    public float nextFire = 0.0f;

    // Use this for initialization
    void Start ()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {

            playerAudio.clip = enemyShoot;
            playerAudio.Play();

            //Debug.Log("Click");
            nextFire = Time.time + fireRate;
            Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }
}
