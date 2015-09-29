using UnityEngine;
using System.Collections;

public class Upwards : MonoBehaviour {
	float x;
	float y;
	
	void Start () {
		
		x = 1f;
		
	}
	
	void Update () {
		
		gameObject.transform.position += Vector3.up * x * Time.deltaTime;
		y = GameObject.Find ("Step2").transform.position.y;
		
		if (y >= 15f) {
			x = -x;
		}
		
		if (y <= 7.5f) {
			x = -x;
		}
	}
}
