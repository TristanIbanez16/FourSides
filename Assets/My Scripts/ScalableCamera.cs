using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ScalableCamera : MonoBehaviour
{

    //The aspect ratio you did for the game.
    public float targetRatio = 16f / 9f; 

    // Use this for initialization
    void Start()
    {
        Camera cam = GetComponent<Camera>();
        cam.aspect = targetRatio;
    }
}