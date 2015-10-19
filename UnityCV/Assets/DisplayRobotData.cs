using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayRobotData : MonoBehaviour 
{
	private float x_coord=0.0f;
	private float y_coord=0.0f;
	private float z_coord=0.0f;
	
	public Text x_text;
	public Text y_text;
	public Text z_text;
	
	public Transform robot_Transform;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (robot_Transform) 
		{
			x_coord = robot_Transform.transform.position.x;
			y_coord = robot_Transform.transform.position.y;
			z_coord = robot_Transform.transform.position.z;
			
			x_text.text = x_coord.ToString ();
			y_text.text = y_coord.ToString ();
			z_text.text = z_coord.ToString ();
		}
	}
}
