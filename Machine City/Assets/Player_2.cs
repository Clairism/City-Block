using UnityEngine;
using System.Collections;

public class Player_2 : MonoBehaviour {

	private float speed;
	private float RotationSpeed = -2;
	private float xSpeed;
	private float ySpeed;

	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	
	void Start () {
		
		speed = 5f;
	
	}
	
	void Update () {
		xSpeed = Input.GetAxis ("Horizontal2") * speed * Time.deltaTime;
		ySpeed = Input.GetAxis ("Vertical2") * -speed * Time.deltaTime;

		transform.Translate (Vector3.forward * xSpeed);
		transform.Translate (Vector3.left * ySpeed);


		transform.Rotate (0, (Input.GetAxis ("Mouse X") * RotationSpeed), 0, Space.World);


		//jump
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump2"))
				moveDirection.y = jumpSpeed;
			
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);

	}
}