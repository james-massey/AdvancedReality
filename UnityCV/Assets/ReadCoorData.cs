using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System;

public class ReadCoorData : MonoBehaviour 
{
	public Transform target;

	private float time = 3.0f;
	private float timer = 0.0f;
	
	private string textFile = "C:/Users/Megatron/Documents/UnityCV/Assets/TestCoordinates.txt";

	private List<Vector3> Coordinates = new List<Vector3>();

	private List<Vector3> Load(string fileName)
	{
		List<Vector3> coordinates = new List<Vector3> ();
		Vector3 coords = new Vector3 ();
		string line;

		StreamReader theReader = new StreamReader (fileName);
			
		using (theReader) 
		{
			// While there's lines left in the text file, do this:
			do 
			{
				line = theReader.ReadLine ();
					
				if (line != null) 
				{
					//Debug.Log (line);
					string[] entries = line.Split (',');
					coords = new Vector3(float.Parse(entries[0]), float.Parse(entries[1]), float.Parse(entries[2]));
					coordinates.Add(coords);
				}
			}while (line != null);

			// Done reading, close the reader and return true to broadcast success    
			theReader.Close ();
		}
		return coordinates;
	}


// Use this for initialization
void Start ()
{
		Coordinates=Load(textFile);
}

// Update is called once per frame
void Update () 
{
		timer += Time.deltaTime;
		if (Coordinates.Count > 0) {
			if (timer > time) {
				target.position = Coordinates [0];
				Coordinates.Remove (Coordinates [0]);
				timer = 0.0f;
			}
		} 
		else 
		{
			Coordinates=Load (textFile);
		}
		/*
		Coordinates=Load(textFile);
		foreach (Vector3 vector in Coordinates)
		{
			Debug.Log (vector);
		}
		*/
}

}
