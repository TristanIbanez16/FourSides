using UnityEngine;
using System.Collections;

public class BasicEnemyMove : MonoBehaviour {

	private int speed = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.localPosition += transform.right * speed * Time.deltaTime; // or transform.position, both would work
	}
}
