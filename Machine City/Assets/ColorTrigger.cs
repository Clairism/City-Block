using UnityEngine;
using System.Collections;

public class ColorTrigger : MonoBehaviour {
	
	private float TriggerColor;

	void Start(){
		
		TriggerColor = gameObject.GetComponent<MeshRenderer> ().material.color;
	}
	
	void Update(){
		
		if (TriggerColor.Equals(Color.yellow)) {
			
			TriggerColor = Color.red;
			
		}
	}
	
	
	void OnTriggerEnter( Collider other){
		
		TriggerColor = Color.yellow;
		
	}
}
