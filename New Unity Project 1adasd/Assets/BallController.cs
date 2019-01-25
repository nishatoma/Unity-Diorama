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
		if (!returnKey ().Equals ("r") && !returnKey ().Equals ("t") && !returnKey ().Equals ("m")) {
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
		}
	}

	string returnKey() {
		if (Input.GetKey (KeyCode.T)) {
			// Translation
			return "t";	
		} else if (Input.GetKey (KeyCode.R)) {
			// Rotation
			return "r";
		} else if (Input.GetKey (KeyCode.M)) {
			// Rotation
			return "m";
		}else {
			return Input.anyKey.ToString();
		}
	}
}
