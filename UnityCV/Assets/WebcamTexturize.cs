using UnityEngine;
using System.Collections;

public class WebcamTexturize : MonoBehaviour {

	public GameObject groundPlane;
	private WebCamTexture w_Texture;
	private WebCamDevice device;

	// Use this for initialization
	void Start () 
	{
		WebCamDevice[] devices = WebCamTexture.devices;
		device = devices [0];
	
			w_Texture = new WebCamTexture(device.name);
			groundPlane.GetComponent<Renderer>().material.mainTexture=w_Texture;
			w_Texture.Play();

		//foreach (var device in devices)
			//Debug.Log (device.name);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
