using UnityEngine;
using System.Collections;

public class PlayerTrigger2 : MonoBehaviour {

	public bool TwoEnter = false;

  void OnTriggerEnter (Collider other){
		TwoEnter = true;
	}

	void OnTriggerExit( Collider other){

		TwoEnter = false;

	}
}
