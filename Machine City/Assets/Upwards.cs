using UnityEngine;
using System.Collections;

public class Upwards : MonoBehaviour {
	private float x;
	private float y;
	
	void Start () {
		
		x = 0.5f;
		
	}
	
	void Update () {
		
		gameObject.transform.position += Vector3.up * x * Time.deltaTime;
		y = GameObject.Find ("Building-1").transform.position.y;
		
			if (y >= 10f) {
				x = -x;
			}
			
			if (y <= 8f) {
				x = -x;
			}
	}
}
