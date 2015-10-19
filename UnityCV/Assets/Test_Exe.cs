using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Test_Exe : MonoBehaviour 
{
	private string applicationPath;

	//private string filepath = "C:/Users/Megatron/Documents/GitHub/AdvancedReality/UnityCV/Assets/UpdateTextCoordinates.py";

	private string fileName = "UpdateTextCoordinates.py";
	private string path;

	Process my_process;

	private float time = 2.0f;
	private float timer = 0.0f;

	// Use this for initialization
	void Start ()
	{
		applicationPath = Application.dataPath;
		//UnityEngine.Debug.Log (applicationPath);
		path = applicationPath + "/" + fileName;
		//UnityEngine.Debug.Log (path);


		my_process= new Process();												//Create a new process
		my_process.StartInfo.FileName = "python.exe";							//Specifies program to run
		my_process.StartInfo.Arguments = path;									//Specifies file location
		my_process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;			//Hides window
		my_process.Start ();													//Start the process
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		if (timer > time) 
		{
			my_process.Close();
			my_process.Start();
			timer = 0.0f;
		}

	}
}
