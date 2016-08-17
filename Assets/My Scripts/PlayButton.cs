using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    public string Level;

    public void onClick()
    {
        StartCoroutine("ChangeLevelCo");
    }

    public IEnumerator ChangeLevelCo()
    {
        yield return new WaitForSeconds(0.6f);

        float fadeTime = GameObject.Find("Game Manager").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(Level);
    }
}
