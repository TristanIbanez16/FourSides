using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class ContinueButton : MonoBehaviour {

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip click;

    Camera MainCamera;
    BlurOptimized blurEffect;

    bool paused = false;

    public GameObject PauseMenuCanvas;
    public Canvas Canvas;

    void Start()
    {
        MainCamera = GameObject.Find("Game Camera").GetComponent<Camera>();
        blurEffect = MainCamera.GetComponent<BlurOptimized>();
    }

    public void OnClick()
    {
        //playerAudio.clip = click;
        //playerAudio.Play();

        Time.timeScale = 1f;
        Canvas.enabled = true;
        blurEffect.enabled = false;

        PauseMenuCanvas.SetActive(false);
    }

}
