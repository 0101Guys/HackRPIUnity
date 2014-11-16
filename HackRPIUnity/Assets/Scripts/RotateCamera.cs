using UnityEngine;
using System.Collections;

public class RotateCamera : MonoBehaviour {

	private float rotSpeed = 20f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * Time.deltaTime * rotSpeed);
		}

		if (Input.GetKey (KeyCode.LeftArrow)){
			transform.Rotate (-Vector3.up * Time.deltaTime * rotSpeed);
		}
	}
}
