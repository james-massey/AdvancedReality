using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	public GameObject MainCamera;
	public GameObject Camera_2;
	//public Camera Camera_3;

	public void SwitchtoMainCamera()
	{
		Camera_2.SetActive (false);
		MainCamera.SetActive (true);
	}

	public void SwitchtoCamera2()
	{
		Camera_2.SetActive (true);
		MainCamera.SetActive (false);
	}

	// Use this for initialization
	void Start () 
	{
		MainCamera.SetActive (true);
		Camera_2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
