using UnityEngine;
using System.Collections;

public class PlayerTrigger2 : MonoBehaviour {

	public bool TwoEnter = false;
	
	
	void OnTriggerEnter( Collider other){
		
		//gameObject.transform.Translate(Vector3.up * x * Time.deltaTime);
		gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
	}
}
