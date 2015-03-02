using UnityEngine;
using System.Collections;
using VRWidgets;

public class LoadPlanet : ButtonToggleBase 
{
	
	public ButtonDemoGraphics onGraphics;
	public ButtonDemoGraphics offGraphics;
	public ButtonDemoGraphics midGraphics;
	public ButtonDemoGraphics botGraphics;
	private bool localVisible;
	public GameObject item;
	//public string spawnLocation;
	
	
	
	/*
	public void Show(bool status){
		Renderer[] renderers = Menu.GetComponentsInChildren<Renderer>();
		foreach (Renderer renderer in renderers)
		{
			renderer.enabled = status;
		}
	}*/
	
	
	
	void Start(){
		//Show (false);		
		localVisible = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<ButtonDemoToggle>().Visible;
	}
	
	
	
	
	public override void ButtonTurnsOn()
	{
		
		localVisible = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<ButtonDemoToggle>().Visible;


		
		if (localVisible) {
			
			TurnsOnGraphics ();

			string planetTag = this.tag;



			switch (planetTag)
			{

			

			//MAIN MENU
			case "ChemistryButton":
				Application.LoadLevel("Chemistry");
				break;
			case "AstronomyButton":
				Application.LoadLevel("Mercury");
				break;
			case "ArchitectureButton":
				Application.LoadLevel("Architecture");
				break;
			case "Augmented":
				Application.LoadLevel("Augmented");
				break;
			case "ExtraButton":
				Debug.Log ("MainMenu!");
				Application.LoadLevel("MainMenu");
				break;
			case "ResetButton":
				Application.LoadLevel(Application.loadedLevel);
				break;

			//CHEMISTRY SECTION

			case "AddAtom":
				//Place code here
				break;
			case "AddRod":
				//Place code here
				break;

			case "AddBlock":
				Transform buttonTransform = GameObject.FindGameObjectWithTag ("SpawnLocation").transform;
				Instantiate (item, new Vector3 (buttonTransform.localPosition.x, buttonTransform.localPosition.y,
				                                buttonTransform.localPosition.z), buttonTransform.rotation);
				Debug.Log ("created earth");
				break;


			//ASTRONOMY SECTION
			case "MercuryButton":
			Application.LoadLevel("Mercury");
			break;
			case "VenusButton":
			Application.LoadLevel("Venus");
			break;
			case "EarthButton":
			Application.LoadLevel("Earth");
			break;
			case "MarsButton":
			Application.LoadLevel("Mars");
			break;
			case "JupiterButton":
			Application.LoadLevel("Jupiter");
			break;
			case "SaturnButton":
			Application.LoadLevel("Saturn");
			break;
			case "UranusButton":
			Application.LoadLevel("Uranus");
			break;
			case "NeptuneButton":
			Application.LoadLevel("Neptune");
			break;
			

			
			default:
				//Console.WriteLine("Default case");
				break;
			}

/*

			if (this.tag.Equals("MercuryButton")) {
				Debug.Log ("Mercury!");
			}
			
			if (this.tag == "EarthButton") {
				Debug.Log ("EARTH!");
			}
*/




			//Application.LoadLevel (1);
			//Debug.Log("LOAD SCENE");
		}
		//Show (true);
		//GameObject.FindGameObjectWithTag ("Player").transform.Translate(Vector3.right * Time.deltaTime);
		/*Debug.Log (GameObject.FindGameObjectWithTag ("Player").transform.position.x);
		float temp = cameraPlayer.transform.position.x;
		cameraPlayer.transform.TransformPoint (GameObject.Find ("MARS").transform.position);

		foreach (Transform child in transform) {
			child.position += Vector3.up * 10.0F;
		}*/
		
		
		
		
		//SetMoveStatus (true);
	}
	
	public override void ButtonTurnsOff()
	{
		localVisible = GameObject.FindGameObjectWithTag ("MenuButton").GetComponent<ButtonDemoToggle>().Visible;

		if (localVisible) {
			TurnsOffGraphics ();
		}
		//Show (false);
		
	}
	
	
	
	
	private void TurnsOnGraphics()
	{
		onGraphics.SetActive(true);
		offGraphics.SetActive(false);
		onGraphics.SetBloomGain(3.0f);
		midGraphics.SetBloomGain(10.0f);
		midGraphics.SetColor(new Color(0.0f, 0.05f, 0.05f, 1.0f));
		botGraphics.SetBloomGain(2.5f);
		botGraphics.SetColor(new Color(0.0f, 1.0f, 1.0f, 1.0f));
	}
	
	private void TurnsOffGraphics()
	{
		onGraphics.SetActive(false);
		offGraphics.SetActive(true);
		offGraphics.SetBloomGain(1.0f);
		midGraphics.SetBloomGain(1.0f);
		midGraphics.SetColor(new Color(0.0f, 0.05f, 0.05f, 0.25f));
		botGraphics.SetBloomGain(1.0f);
		botGraphics.SetColor(new Color(0.0f, 0.1f, 0.1f, 1.0f));
	}
	
	private void UpdateGraphics()
	{
		Vector3 position = GetPosition();
		onGraphics.transform.localPosition = position;
		offGraphics.transform.localPosition = position;
		Vector3 bot_position = position;
		bot_position.z = Mathf.Max(bot_position.z, onDistance);
		botGraphics.transform.localPosition = bot_position;
		Vector3 mid_position = position;
		mid_position.z = (position.z + bot_position.z) / 2.0f;
		midGraphics.transform.localPosition = mid_position;
	}
	
	public override void Awake()
	{
		base.Awake();
		TurnsOffGraphics();
	}
	
	public override void Update()
	{
		base.Update();
		UpdateGraphics();
		
		
		
		
	}
}
