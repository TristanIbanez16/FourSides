using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause1 : MonoBehaviour {

    bool paused = false;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {

        //if the Key P or ESC is pressed the boolean is toggled to true
        if (Input.GetButtonDown("pauseButton"))
            paused = togglePause();

        if (Input.GetMouseButtonDown(0))
        {

        }

    }

    void OnGUI()
    {
        //GUI.color = Color.black;

        // a text and button are displayed.
        if (paused)
        {
            GUILayout.Label("  Paused");

            if (GUILayout.Button("Continue"))
            {
                paused = togglePause();
            }

            else if (GUILayout.Button("Reset"))
            {
                SceneManager.LoadScene("four Sides Prototype Level");
                Time.timeScale = 1f;
                Destroy(this.gameObject);
            }
            else if (GUILayout.Button("Exit"))
            {
                Application.Quit();
            }
        }
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return (false);
        }
        else
        {
            Time.timeScale = 0f;
            return (true);
        }
    }
}
