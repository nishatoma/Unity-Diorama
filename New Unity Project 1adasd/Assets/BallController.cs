using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update() {
		//transform.Translate (Vector3.forward * 10 * Time.deltaTime);
	}

	void FixedUpdate () {
		/*
		 * 
		float moveHorizontal = Input.GetAxis ("Horizontal") * speed;
		float moveVertical = Input.GetAxis ("Vertical") * rotationSpeed;

		Vector3 movement = new Vector3 (-moveVertical, 0, moveHorizontal);

		// If the player presses space
		if (Input.GetKey(KeyCode.Space)) {
			Vector3 up = new Vector3 (0, 10, 0);
			rb.AddForce (up * speed/5);
		}

		rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		rb.AddForce (movement);
		*/
	}
}
