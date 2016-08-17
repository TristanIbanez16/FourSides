using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class PauseMenu : MonoBehaviour {

    Camera MainCamera;
    BlurOptimized blurEffect;

    Player playerController;
    Shooter playerControllerShooter;

    bool paused = false;

    public GameObject PauseMenuCanvas;
    public Canvas Canvas;

    // Use this for initialization
    void Start()
    {
        MainCamera = GameObject.Find("Game Camera").GetComponent<Camera>();
        blurEffect = MainCamera.GetComponent<BlurOptimized>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerControllerShooter = GameObject.Find("Bullet Spawn Point").GetComponent<Shooter>();
    }

    // Update is called once per frame
    void Update ()
    {
        if(Input.GetButtonDown("Pause"))
        {
            Canvas.enabled = false;
            paused = togglePause();
        }
	}

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            Canvas.enabled = true;
            blurEffect.enabled = false;
            playerController.enabled = true;
            playerControllerShooter.enabled = true;

            PauseMenuCanvas.SetActive(false);

            return (false);

        }
        else
        {
            blurEffect.enabled = true;
            playerController.enabled = false;
            playerControllerShooter.enabled = false;

            PauseMenuCanvas.SetActive(true);

            Time.timeScale = 0f;
            return (true);
        }
    }
}
