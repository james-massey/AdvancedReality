using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplaySphereData : MonoBehaviour 
{
	private float x_coord=0.0f;
	private float y_coord=0.0f;
	private float z_coord=0.0f;

	public Text x_text;
	public Text y_text;
	public Text z_text;

	public Transform sphere_Transform;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (sphere_Transform) 
		{
			x_coord = sphere_Transform.transform.position.x;
			y_coord = sphere_Transform.transform.position.y;
			z_coord = sphere_Transform.transform.position.z;

			x_text.text = x_coord.ToString ();
			y_text.text = y_coord.ToString ();
			z_text.text = z_coord.ToString ();
		}
	}
}
