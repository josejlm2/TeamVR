using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	bool showMenu = false;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.M)){
			showMenu = true;
		}
	}



	void OnGUI (){
		if (showMenu == true){
			GUI.Box (new Rect (10, 10, 150, 200), "Loader Menu");
			
			
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect (20, 40, 130, 20), "Main Menu")) {
				Application.LoadLevel (0);
			}
			// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
			if (GUI.Button (new Rect (20, 70, 130, 20), "Solar System")) {
				Application.LoadLevel (1);
			}
			
			// Make the second button.
			if (GUI.Button (new Rect (20, 100, 130, 20), "Room")) {
				Application.LoadLevel (2);
			}
		
			// Make the second button.
			if (GUI.Button (new Rect (20, 130, 130, 20), "Initial Version")) {
				Application.LoadLevel (3);
			}
		}

	}
}