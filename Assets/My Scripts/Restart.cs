using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public AudioSource playerAudio;                             // Reference to the AudioSource component.
    public AudioClip click;

    public string Level;

    public void OnClick()
    {
        StartCoroutine("ChangeLevelCo");

    }

    public IEnumerator ChangeLevelCo()
    {
        Debug.Log("Hi");
        yield return new WaitForSeconds(0.6f);

        float fadeTime = GameObject.Find("Level Fade").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(Level);
    }
}
