using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class ContinueButton : MonoBehaviour {

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip click;

    Camera MainCamera;
    BlurOptimized blurEffect;
    Player playerController;
    Shooter playerControllerShooter;

    bool paused = false;

    public GameObject PauseMenuCanvas;
    public Canvas Canvas;

    void Start()
    {
        MainCamera = GameObject.Find("Game Camera").GetComponent<Camera>();
        blurEffect = MainCamera.GetComponent<BlurOptimized>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerControllerShooter = GameObject.Find("Bullet Spawn Point").GetComponent<Shooter>();
    }

    public void OnClick()
    {
        //playerAudio.clip = click;
        //playerAudio.Play();

        Time.timeScale = 1f;
        playerController.enabled = true;
        playerControllerShooter.enabled = true;
        Canvas.enabled = true;
        blurEffect.enabled = false;

        PauseMenuCanvas.SetActive(false);
    }

}
