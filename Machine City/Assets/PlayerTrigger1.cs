using UnityEngine;
using System.Collections;

public class PlayerTrigger1 : MonoBehaviour {

   public bool OneEnter = false;
	
	
	void OnTriggerEnter( Collider other){
		
		gameObject.GetComponent<MeshRenderer> ().material.color = Color.yellow;
		OneEnter = true;
	}

	void OnTriggerExit( Collider other){
		
		OneEnter = false;
		
	}
	

}
