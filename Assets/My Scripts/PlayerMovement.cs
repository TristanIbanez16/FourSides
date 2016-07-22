using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * 4f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}
