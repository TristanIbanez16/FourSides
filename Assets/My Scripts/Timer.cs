using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private Text timerText; 

    private float timer;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        timerText.text = "Time: " + timer.ToString("0.0s");
	}
}
