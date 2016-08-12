using UnityEngine;
using System.Collections;

public class TwoTargetMover : MonoBehaviour {

	public Transform end0;
	public Transform end1;
	private int enemymover = 10;

	public float speed = 1.0f;

	private Transform target;

	void Start()
	{
		target = end0;
	}

	// Update is called once per frame
	void Update () 
	{
		

		for (int i = 0; i <= enemymover; i++) 
		{
			float distance = Vector3.Distance (transform.position, target.position);

			if (distance < 0.5f) 
			{
				target = end1;
			}

			transform.position = Vector3.Lerp (transform.position, target.position, speed * Time.deltaTime);


		}
		
	}
}
