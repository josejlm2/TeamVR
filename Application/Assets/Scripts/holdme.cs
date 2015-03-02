using UnityEngine;
using System.Collections;

public class holdme : MonoBehaviour {
	
	void OnTriggerEnter(Collider col){
		
//		transform.parent.GetComponent<UpDownPlatform> ().player = col.GetComponent<CharacterController> ();
		if (col.GetComponent<HandController> () != null && col.GetComponent<HandController> ().GetFrame ().Hands [1].PinchStrength > 0)
						transform.parent.parent = col.transform;
				else 
						transform.parent.parent = null;
		// Try this: http://answers.unity3d.com/questions/8207/charactercontroller-falls-through-or-slips-off-mov.html
	}
	
	void OnTriggerExit(Collider col){
		//		transform.parent.GetComponent<UpDownPlatform> ().player = null;
		transform.parent.parent = null;
		//		col.transform.parent = null;
		//		col.transform.SetParent (null);	 
	}
}
