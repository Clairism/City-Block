using UnityEngine;
using System.Collections;

public class Upwards2 : MonoBehaviour {
	private float x;
	
	void Start () {
		
		x = 5f;
		
	}
	
	void Update () {
		
		gameObject.transform.Rotate(Vector3.up * x * Time.deltaTime);

		}
	}

