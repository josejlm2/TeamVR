//Top Banner
var topBannerH : float;
var topBannerW : float;
//Buttons
var buttonSizeH : float;
var buttonSizeW : float;
var buttonPos1 : float;
var buttonPos2 : float;
var buttonPos3 : float;
var buttonPos4 : float;
var buttonPos5 : float;
//Bottom Banner
var bottomBannerH : float;
var bottomBannerW : float;
var bottomBannerPos : float;
var exampleVar1 : String;
var customSkin1 : GUISkin;
var customSkin2 : GUISkin;
var customSkin3 : GUISkin;

function Awake () {
	topBannerH = Screen.height/4;
	topBannerW = Screen.width;
	buttonSizeH = Screen.height/10;
	buttonSizeW = Screen.width;
	buttonPos1 = topBannerH;
	buttonPos2 = topBannerH+buttonSizeH;
	buttonPos3 = topBannerH+buttonSizeH*2;
	buttonPos4 = topBannerH+buttonSizeH*3;
	buttonPos5 = topBannerH+buttonSizeH*4;
	bottomBannerH = Screen.height/4;
	bottomBannerW =  Screen.width;
	bottomBannerPos = topBannerH+buttonSizeH*5;	
}

function OnGUI() {
	GUI.skin = customSkin1;
	//Title Banner
	GUI.Box(Rect(0,0,topBannerW,topBannerH),exampleVar1);
	
	GUI.skin = customSkin2;
	//Button 1
	if (GUI.Button(Rect(0,buttonPos1,buttonSizeW,buttonSizeH),"gravity")){
		Debug.Log("Clicked the button gravity");
		Application.LoadLevel("gravity");
	}
	//Button 2
	if (GUI.Button(Rect(0,buttonPos2,buttonSizeW,buttonSizeH),"friction")){
		Debug.Log("Clicked the button friction");
		Application.LoadLevel("friction");
	}
	//Button 3
	if (GUI.Button(Rect(0,buttonPos3,buttonSizeW,buttonSizeH),"collision")){
		Debug.Log("Clicked the button collision");
		Application.LoadLevel("collision");
	}
	//Button 4
	if (GUI.Button(Rect(0,buttonPos4,buttonSizeW,buttonSizeH),"ball room")){
		Debug.Log("Clicked the button ball room");
		Application.LoadLevel("ballroom");
	}
	//Button 5
	if (GUI.Button(Rect(0,buttonPos5,buttonSizeW,buttonSizeH),"virtual room")){
		Debug.Log("Clicked the button virtual room");
		Application.LoadLevel("virtural");
	}
	
	GUI.skin = customSkin3;
	//Bottom Banner
	GUI.Box(Rect(0,bottomBannerPos,bottomBannerW,bottomBannerH),"have fun");
}
