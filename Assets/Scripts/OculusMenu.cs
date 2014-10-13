using UnityEngine;
using System.Collections;



public class OculusMenu : VRGUI {

	private float boxWidth = Screen.width / 5;
	private float boxHeight = Screen.height / 20;


	//var speed = getRotationSpeed();
	public override void OnVRGUI()
	{
		var speed = 5.0f;



		
		GUILayout.BeginArea(new Rect(60f, 20f, 50f, 50f));
		if (GUILayout.Button("Click Me!"))
		{
			Debug.Log ("Test");
		}



		GUILayout.Box("Moon's Rotation Speed: " + Mathf.Round(speed));
		speed = GUILayout.HorizontalSlider (speed, 0.0f, 50.0f);

		GUILayout.EndArea();


		if (GUI.Button (new Rect ((Screen.width / 2.0f) - (boxWidth/2), (Screen.height/10) - (boxHeight / 2), boxWidth, boxHeight), "Load Game")) {
			Application.LoadLevel(1);
		}
		
		if (GUI.Button (new Rect ((Screen.width / 2.0f) - (boxWidth/2), ((Screen.height/10)) + (boxHeight / 2), boxWidth, boxHeight), "Exit")) {
			Application.Quit();
		}

		if (GUI.Button (new Rect (0, 0, 100,50), "Top-left")) {
			Application.Quit();
		}

		GUI.Button (new Rect (Screen.width - 100,0,100,50), "Top-right");
		GUI.Button (new Rect (0,Screen.height - 50,100,50), "Bottom-left");
		GUI.Button (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Bottom-right");

	}
}