using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    float y;
	float x;


	// Use this for initialization
	void Start () {

		x = .1f;
		//t = 0;
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (new Vector3 (x, 0, 0));
		//print(y);
		//t += 1 * Time.deltaTime;
		y = GameObject.Find ("Steps").transform.position.y;

		//y = transform.position.y;
		if (y >= 4.5f) {
			x=-x;
		}

		if (y <= 0f) {
			x=-x;
		}

	}
}