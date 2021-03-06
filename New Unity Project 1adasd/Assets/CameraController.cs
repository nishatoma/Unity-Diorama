﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// Get an instance of the sphere
	public GameObject player;
	private string inputPressed;

	// Offset for the camera
	private Vector3 offset;
	public float panSpeed = 10f;

	// Use this for initialization
	void Start () {
		//offset = transform.position - player.transform.position;\
		
	}
	
	// Update is used for following cameras
	// Just like update, runs every frame, but it is guaranteed
	// to run after all items have been proccessed in update.
	void LateUpdate () {
		Vector3 pos = transform.position;
		Quaternion rot = transform.rotation;

		// Every frame
		//transform.position = player.transform.position + offset;
		if (returnKey ().Equals ("t")) {
			if (Input.GetKey (KeyCode.W)) {
				pos.x -= panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.S)) {
				pos.x += panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.A)) {
				pos.z -= panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.D)) {
				pos.z += panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.UpArrow)) {
				pos.y += panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.DownArrow)) {
				pos.y -= panSpeed * Time.deltaTime;
			} 
			transform.position = pos;
		} else if (returnKey ().Equals ("r")) {
			if (Input.GetKey (KeyCode.W)) {
				rot.z += panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.S)) {
				rot.z -= panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.A)) {
				rot.x -= panSpeed * Time.deltaTime;
			} else if (Input.GetKey (KeyCode.D)) {
				rot.x += panSpeed * Time.deltaTime;
			}
			transform.rotation = rot;
		}
	}

	string returnKey() {
		if (Input.GetKey (KeyCode.T)) {
			// Translation
			inputPressed = "t";
			return "t";	
		} else if (Input.GetKey (KeyCode.R)) {
			// Rotation
			inputPressed = "r";
			return "r";
		} else {
			return "";
		}
	}
}
