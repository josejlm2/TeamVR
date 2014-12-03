#pragma strict

function Update(){
	if (Input.GetKey(KeyCode.Escape)) {
    	Application.Quit();
	}
	
	if (Input.GetKey(KeyCode.Backspace)) {
    	Application.LoadLevel("Menu Main");
	}
	
	if (Input.GetKey(KeyCode.Alpha1)) {
    	Application.LoadLevel("Mercury Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha2)) {
    	Application.LoadLevel("Venus Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha3)) {
    	Application.LoadLevel("Earth Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha4)) {
    	Application.LoadLevel("Mars Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha5)) {
    	Application.LoadLevel("Jupiter Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha6)) {
    	Application.LoadLevel("Saturn Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha7)) {
    	Application.LoadLevel("Uranus Subject");
	}
	
	if (Input.GetKey(KeyCode.Alpha8)) {
    	Application.LoadLevel("Neptune Subject");
	}
	
	var goToPluto;
	
	if (Input.GetButton("Fire1") && Input.GetButton("Fire2")) {
     	goToPluto = true;
 	}
 
 	if (goToPluto) {
 		Application.LoadLevel("Pluto Subject");
     	goToPluto = false;
 	}
 
	/*if (Input.GetButton(KeyCode.LeftShift) && ) {
    	if (Input.GetKey(KeyCode.Alpha9)) {
    		Application.LoadLevel("Pluto Subject");
    	}
	}*/
}