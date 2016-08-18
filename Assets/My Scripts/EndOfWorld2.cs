using UnityEngine;
using System.Collections;

public class EndOfWorld2 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("EndOfWorld2", 1);
        }
    }
}
