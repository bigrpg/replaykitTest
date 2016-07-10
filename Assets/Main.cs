using UnityEngine;
using System.Collections;
using System;

public class Main : MonoBehaviour {
	UILabel label;


	// Use this for initialization
	void Start () {
		label = GetComponent<UILabel>();
	}
	
	// Update is called once per frame
	void Update () {	
		label.text = DateTime.Now.ToString();
	}

	void OnGUI()
	{
		if (GUI.Button(new Rect(50, 50, 200, 50), "Start"))
		{
			ReplayManager.StartRecording();
		}

		if (GUI.Button(new Rect(50, 150, 200, 50), "Stop"))
		{
			ReplayManager.StopRecording();
		}

		if (GUI.Button(new Rect(50, 250, 200, 50), "Discard"))
		{
			ReplayManager.DiscardRecording();
		}

		if (GUI.Button(new Rect(50, 350, 200, 50), "Replay"))
		{
			ReplayManager.DisplayRecordingContent();
		}
	}


}
