using UnityEngine;
using System.Collections;

public class TurnBack : MonoBehaviour {

	float y;
	float x;

	// Use this for initialization
	void Start () {

		x = .1f;
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (new Vector3 (x, 0, 0));

	
		if (y >= 4.5f) {

			y = transform.position.y;
			x=-x;
		}

	
	}
}
