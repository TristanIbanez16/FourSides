using UnityEngine;
using System.Collections;

public class GunSpawnPointTurner : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        // if the player press the key D, the gun spawn point flips to the right
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        // if the player press the key A, the gun spawn point flips to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles = new Vector2(0, 180);
        }

        // if the player press the right arrow key, the gun spawn point flips to the left
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        // if the player press the left arrow key, the gun spawn point flips to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector2(0, 180);
        }

    }
}
