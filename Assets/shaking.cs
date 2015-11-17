using UnityEngine;
using System.Collections;

public class shaking : MonoBehaviour {

	public float shakeAmount = 2f;
	public float shakeTime = 1.5f;

	private bool isShaking = false;
	private Vector3 originalLocation;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {
		if (Input.GetKey (KeyCode.Space) ){
			StartCoroutine ("shakeScreen");
		}

		if (isShaking){

			transform.position = originalLocation + Random.insideUnitSphere * Time.deltaTime * shakeAmount;

		}
	}

	IEnumerator shakeScreen(){
		isShaking = true;
		originalLocation = transform.position;
		yield return new WaitForSeconds (shakeTime);
		isShaking = false;
		//transform.position = originalLocation;
	}
}