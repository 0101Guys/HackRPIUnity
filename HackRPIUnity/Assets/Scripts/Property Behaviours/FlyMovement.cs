using UnityEngine;
using System.Collections;

public class FlyMovement : MonoBehaviour {

	private float speed = 1f;
	public float xScale = 1f;
	public float yScale = 1f;

	private Vector3 pivot;
	private Vector3 pivotOffset;
	private float phase;
	private bool invert = false;
	private float m2pi = Mathf.PI * 2;

	// Use this for initialization
	void Start () {
		pivot = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		pivotOffset = Vector3.up * 2 * yScale;

		phase += speed * Time.deltaTime;
		if (phase > m2pi) {
			invert = !invert;
			phase -= m2pi;
		}

		if (phase < 0) {
			phase+= m2pi;
		}

		transform.position = pivot + (invert ? pivotOffset : Vector3.zero);
		float tempX = transform.position.x;
		float tempY = transform.position.y;
		tempX = tempX + Mathf.Sin (phase) * xScale;
		tempY = tempY + Mathf.Cos (phase) * (invert ? -1 : 1) * yScale;
		transform.position = new Vector3(tempX, tempY, transform.position.z);
	}
}
