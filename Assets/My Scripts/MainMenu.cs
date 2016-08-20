using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private GameObject BackgroundMusic;
    private GameObject BackgroundMusic2;

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip click;

    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        BackgroundMusic = GameObject.Find("Audio Source");
        BackgroundMusic = GameObject.Find("Music(Clone)");
    }

    public void OnClick()
    {
        //playerAudio.clip = click;
        //playerAudio.Play();

        StartCoroutine("MenuCo");

    }

    IEnumerator MenuCo()
    {

        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;

        }

        yield return new WaitForSeconds(0.2f);
        float fadeTime = GameObject.Find("Game Manager").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene("Menu");
        Destroy(BackgroundMusic2);
        Destroy(BackgroundMusic);
    }

}
