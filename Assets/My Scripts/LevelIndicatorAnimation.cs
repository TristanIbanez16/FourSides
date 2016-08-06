using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class LevelIndicatorAnimation : MonoBehaviour {

    private float timer;
    private float blurTime;

    private GameObject playerMovement;
    Player player;

    DepthOfField blurEffect;

	// Use this for initialization
	void Start ()
    {
        blurTime = 0.4f;

        blurEffect = GetComponent<DepthOfField>();

        playerMovement = GameObject.FindGameObjectWithTag("Player");
        player = playerMovement.GetComponent<Player>();

        player.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if(timer > 4f)
        {
            blurEffect.aperture -= blurTime * Time.deltaTime;   
        }


        if (timer > 5f)
        {
            player.enabled = true;
        }
    }
}
