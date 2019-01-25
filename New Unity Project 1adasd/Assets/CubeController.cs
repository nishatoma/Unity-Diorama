using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	bool isVisibile = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F)) {
			isVisibile = !isVisibile;
			//this.gameObject.SetActive (!isVisibile);
		}
	}
}
