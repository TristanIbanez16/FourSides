using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public string Level;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine("ChangeLevelCo");
        }
    }

    public IEnumerator ChangeLevelCo()
    {
        yield return new WaitForSeconds(0.6f);

        float fadeTime = GameObject.Find("Level Fade").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(Level);
    }
}
