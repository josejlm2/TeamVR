using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float rotationSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.up, rotationSpeed * Time.deltaTime);
	}


	void OnGUI()
	{

		GUILayout.Box("Moon's Rotation Speed: " + Mathf.Round(rotationSpeed));
		rotationSpeed = GUILayout.HorizontalSlider (rotationSpeed, 0.0f, 50.0f);
		
		// End the Groups and Area

	}

	float getRotationSpeed(){

		return rotationSpeed;
	}


}
