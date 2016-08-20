using UnityEngine;
using System.Collections;

public class MusicDeletor : MonoBehaviour {

    private GameObject BackgroundMusic;
    private GameObject BackgroundMusic2;

    // Use this for initialization
    void Awake ()
    {
        BackgroundMusic2 = GameObject.Find("Music(Clone)");
        BackgroundMusic = GameObject.Find("Music");
	}

    void Start()
    {
        if(BackgroundMusic || BackgroundMusic2 != null)
        {
            Destroy(BackgroundMusic);
            Destroy(BackgroundMusic2);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
