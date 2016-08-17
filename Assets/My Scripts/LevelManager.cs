using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;

    public GameObject RespawnParticle;
    public GameObject DeathParticleEffect;

    public GameObject Player;

    public GameObject BulletSpawnPoint;

    private Player player;

    public float respawnDelay;

    KillPlayer playerDeathsCount;

    public static float playerDeaths = 0f;

    // Use this for initialization
    void Start ()
    {
        player = FindObjectOfType<Player>();
	}

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo()
    {
        playerDeaths = 1f;
        Instantiate(DeathParticleEffect, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;

        Player.SetActive(false);

        BulletSpawnPoint.SetActive(false);

        yield return new WaitForSeconds(respawnDelay);  
        player.transform.position = currentCheckpoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;

        Player.SetActive(true);

        BulletSpawnPoint.SetActive(true);

        Instantiate(RespawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }

}
