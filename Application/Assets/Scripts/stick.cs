using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class stick : MonoBehaviour {
	public string moleculeName;
	public List<string> compatibilities;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider collide){
		stick st = collide.gameObject.GetComponent<stick> ();
		
		if (st != null && compatibilities.Contains (st.moleculeName)) {
			Debug.Log ("We have collision!");
			
			if(this.gameObject.transform.parent != null)
			{
				//collide.gameObject.transform.SetParent(this.gameObject.transform.parent);
				collide.gameObject.transform.position = new Vector3(0.8f, 0, 0);
			}
			else if (collide.gameObject.transform.parent != null)
			{
				//this.gameObject.transform.SetParent(collide.gameObject.transform.parent);
				this.gameObject.transform.position = new Vector3(-0.8f, 0, 0);
			}
		}
	}
}
