using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelButton13 : MonoBehaviour {

    public string Level;

    public string LevelGrade;

    public void onClick()
    {
        if (!PlayerPrefs.HasKey("EndOfWorld2"))
        {
            return;
        }
        else if (PlayerPrefs.HasKey("EndOfWorld2"))
        {
            StartCoroutine("ChangeLevelCo");
        }
    }

    public IEnumerator ChangeLevelCo()
    {
        yield return new WaitForSeconds(0.6f);

        float fadeTime = GameObject.Find("Game Manager").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(Level);
    }
}
