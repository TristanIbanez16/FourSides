using UnityEngine;
using System.Collections;

public class PickupAnimation : MonoBehaviour {

    public float rotateSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Random.Range(0, 0), Random.Range(2, 5), Random.Range(0, 0));

        Destroy(gameObject, 10f);
    }
}
