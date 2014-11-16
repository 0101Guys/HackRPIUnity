using UnityEngine;
using System.Collections;

public class FlyUpwards : MonoBehaviour {

	private bool canFly = true;
	public float speed;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (canFly) {
			transform.Translate(Vector3.up * Time.deltaTime);
		}
	}
}
