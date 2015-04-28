using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestMove : MonoBehaviour 
{
	public Transform target;

	private List<Vector3> Coordinates = new List<Vector3>();
	
	private float time = 3.0f;
	private float timer = 0.0f;

	// Use this for initialization
	void Start ()
	{
		Coordinates = ReadCoorData.Coordinates;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Coordinates = ReadCoorData.Coordinates;

		timer += Time.deltaTime;
		if (Coordinates.Count > 0) {
			if (timer > time) 
			{
				target.position = Coordinates [0];
				Coordinates.Remove (Coordinates [0]);
				timer = 0.0f;
			}
		} 
	}
}
