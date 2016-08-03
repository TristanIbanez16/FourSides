using UnityEngine;
using System.Collections;

public class PickupManager : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        // if the gameobject has the tag "Pick Up", disable the game object.
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);

        }
    }
}
