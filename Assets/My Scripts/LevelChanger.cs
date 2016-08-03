using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

    public string Level;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Hi!");
            // load the named level
            SceneManager.LoadScene(Level);
        }
    }
}
