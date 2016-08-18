using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelPlayButton : MonoBehaviour {

    public string Level;

    public string LevelGrade;

    void Start()
    {

    }

    public void onClick()
    {
        if (!PlayerPrefs.HasKey(LevelGrade))
        {
            return;
        }
        else if(PlayerPrefs.HasKey(LevelGrade))
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
