using UnityEngine;
using System.Collections;

public class EndOfWorld1 : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetInt("EndOfWorld1", 1);
        }
    }
}
