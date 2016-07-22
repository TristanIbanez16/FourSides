using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Four Sides Prototype Level");
    }
}
