using UnityEngine;
using System.Collections;

public class MusicCreator : MonoBehaviour {

    public GameObject Music;
	
	// Update is called once per frame
	void Start ()
    {
        if(GameObject.FindGameObjectWithTag("Music") != null)
        {
            return;
        }

        else if(GameObject.FindGameObjectWithTag("Music") == null)
        {
            Instantiate(Music);
        }
	}
}
