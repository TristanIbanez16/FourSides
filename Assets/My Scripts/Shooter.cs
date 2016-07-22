using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	public GameObject BulletPrefab;

	public float fireRate = 1.0f;
	public float nextFire = 0.0f;

	// Update is called once per frame
	void Update () 
	{
        // if the player presses left-click or enter, the gun fires.
		if(Input.GetButtonDown("Fire1") || Input.GetKey(KeyCode.Return))
		{
			if(Time.time > nextFire)
			{
				//Debug.Log("Click");
				nextFire = Time.time + fireRate;
				Instantiate (BulletPrefab, transform.position, transform.rotation);
			}
		}
	}
}
