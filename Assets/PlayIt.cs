using UnityEngine;
using System.Collections;

public class PlayIt : MonoBehaviour {
	private AudioSource weird_sound;

	// Use this for initialization
	void Start () {
		weird_sound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey (KeyCode.P) && weird_sound.isPlaying == false){
			weird_sound.Play ();
			//GetComponentInChildren
		}
	
	}
}
