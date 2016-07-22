using UnityEngine;
using System.Collections;

public class GunTurner : MonoBehaviour {

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        // if the player press the key D, the gun turns to the right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector2(0, 0);

        }

        // if the player press the key D, the gun turns to the left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector2(0, 180);

        }
    }
}
