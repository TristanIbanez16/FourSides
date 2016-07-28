using UnityEngine;
using System.Collections;

public class EnemyShooter : MonoBehaviour {

    public GameObject BulletPrefab;

    public float fireRate = 1.0f;
    public float nextFire = 0.0f;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            //Debug.Log("Click");
            nextFire = Time.time + fireRate;
            Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }
}
