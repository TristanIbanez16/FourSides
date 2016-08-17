using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text timerText; 

    public static float timer;

	// Use this for initialization
	void Start ()
    {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        timerText.text = "" + timer.ToString("0.0s");

	}

}
