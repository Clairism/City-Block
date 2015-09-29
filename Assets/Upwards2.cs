using UnityEngine;
using System.Collections;

public class Upwards2 : MonoBehaviour {
	float x;
	float y;
	
	void Start () {
		
		x = 1.5f;

	}
	
	void Update () {
		
		gameObject.transform.position += Vector3.up * x * Time.deltaTime;
		y = GameObject.Find ("Step3").transform.position.y;

		if (y >= 16.5f) {
			x = -x;
		}
		
		if (y <= 14f) {
			x = -x;
		}
	}
}
