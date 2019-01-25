using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	public float offSet = 1;
	private Light light;

	// Use this for initialization
	void Start () {
		light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.M)) {
			if (Input.GetKey (KeyCode.RightArrow)) {
				light.intensity += offSet;
			} else if (Input.GetKey (KeyCode.LeftArrow)) {
				light.intensity -= offSet;
			}
		}
	}
}
