using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip activateCheckpoint;

    public GameObject activateCheckpointParticle;

    public LevelManager levelManager;

    bool hasBeenTriggered = false;

	// Use this for initialization
	void Start ()
    {
        playerAudio = GetComponent<AudioSource>();
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            if(hasBeenTriggered)
            {
                return;
            }
            else
            {
                hasBeenTriggered = true;
                levelManager.currentCheckpoint = gameObject;

                playerAudio.clip = activateCheckpoint;
                playerAudio.Play();
                Instantiate(activateCheckpointParticle, transform.position, transform.rotation);
                Debug.Log("Activated Checkpoint " + transform.position);
            }

        }
    }
}
