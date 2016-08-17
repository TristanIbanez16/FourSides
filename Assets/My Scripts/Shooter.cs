using UnityEngine;
using System.Collections;


public class Shooter : MonoBehaviour {

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip shoot;

    public GameObject BulletPrefab;

	public float fireRate = 1.0f;
	public float nextFire = 0.0f;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update () 
	{
        // if the player presses left-click or enter, the gun fires.
		if(Input.GetButtonDown("Fire1"))
		{
			if(Time.time > nextFire)
			{
				//Debug.Log("Click");
				nextFire = Time.time + fireRate;

                playerAudio.clip = shoot;
                playerAudio.Play();

                Instantiate (BulletPrefab, transform.position, transform.rotation);
			}
		}
	}
}
