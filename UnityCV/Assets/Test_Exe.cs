using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Test_Exe : MonoBehaviour 
{
	private string applicationPath;

	private string filepath = "C:/Users/Megatron/Documents/GitHub/AdvancedReality/UnityCV/Assets/UpdateTextCoordinates.py";
	Process my_process= new Process();

	private float time = 2.0f;
	private float timer = 0.0f;

	// Use this for initialization
	void Start ()
	{
		applicationPath = Application.dataPath;
		UnityEngine.Debug.Log (applicationPath);
		my_process.StartInfo.FileName = "python.exe";
		my_process.StartInfo.Arguments = filepath;
		my_process.Start ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > time) 
		{
			my_process.Start();
		}
		timer = 0.0f;
	}
}
