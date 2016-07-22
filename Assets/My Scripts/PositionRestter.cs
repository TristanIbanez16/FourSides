using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PositionRestter : MonoBehaviour {

    public Vector3 resetPosition;

    public string myObject;

    private GameObject player;

    void Start()
    {
        // search the scene for the sphere
        player = GameObject.Find(myObject);
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            // resets the position of the player
            player.transform.position = resetPosition;
            SceneManager.LoadScene("Level 1");
            Debug.Log("Hi");
        }
    }
}
