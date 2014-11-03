﻿using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float rotationSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (Vector3.up, rotationSpeed * Time.deltaTime);
	}
}
