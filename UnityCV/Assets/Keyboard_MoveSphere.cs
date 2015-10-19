using UnityEngine;
using System.Collections;

public class Keyboard_MoveSphere : MonoBehaviour 
{
	public GameObject target;
	private int speed = 10;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("w")) 
		{
			target.transform.Translate(Vector3.forward*speed*Time.deltaTime);
		}
		if (Input.GetKey ("d")) 
		{
			target.transform.Translate(Vector3.right*speed*Time.deltaTime);
		}
		if (Input.GetKey ("s")) 
		{
			target.transform.Translate(Vector3.back*speed*Time.deltaTime);
		}
		if (Input.GetKey ("a")) 
		{
			target.transform.Translate(Vector3.left*speed*Time.deltaTime);
		}
	}
}
