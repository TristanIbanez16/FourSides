using UnityEngine;
using System.Collections;

public class DeletePrefs : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("REMEMBER TO DELETE THIS GAME OBJECT");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
