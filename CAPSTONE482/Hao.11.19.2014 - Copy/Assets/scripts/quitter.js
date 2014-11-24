function Update(){
	//quit game if escape key is pressed
	if (Input.GetKey(KeyCode.Escape)) {
    		Application.LoadLevel("Menu");
	}
}