using UnityEngine;
using System.Collections;

public class ColorTrigger : MonoBehaviour {

	private float x = 8f;
	private float y;



	void Update(){

		if (gameObject.GetComponent<"PlayerTrigger1"> ().OneEnter && gameObject.GetComponent<"PlayerTrigger2"> ().TwoEnter) {

			gameObject.GetComponent<MeshRenderer>().material.color = Color.red;

			gameObject.transform.Translate(Vector3.up * x * Time.deltaTime);
		
		}


		y = transform.position.y;
		if (y >= 5.5f) {
			x=0;
		}

	}
	
}
