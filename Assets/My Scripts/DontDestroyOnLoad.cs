using UnityEngine;
using System.Collections;

public class DontDestroyOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //Doesn't destroy GameObject on Load
        DontDestroyOnLoad(this.gameObject);	
	}
	

}
