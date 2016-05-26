using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Mover : MonoBehaviour {

	//meters / second
	public float maxSpeed = 10f;
	public float rotSpeed = 5f;
	public Transform cameraTransform = null;
	private Transform meTransform = null;
	private bool isMoving = false;


	// initialize all variable
	void Awake() {
		this.meTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (this.cameraTransform != null) {

			if (Input.anyKey) {
				if (Input.GetKey ("w")) {
					this.meTransform.position += cameraTransform.forward * (Time.deltaTime * this.maxSpeed);
				}
				if (Input.GetKey ("s")) {
					this.meTransform.position += Vector3.back * (Time.deltaTime * this.maxSpeed);
				}
				if (Input.GetKey ("a")) {
					this.meTransform.position += Vector3.left * (Time.deltaTime * this.maxSpeed);
				}
				if (Input.GetKey ("d")) {
					this.meTransform.position += Vector3.right * (Time.deltaTime * maxSpeed);
				}
				this.isMoving = true;
			} else {
				this.isMoving = false;
			}

		}
	}

	public Vector3 GetTransform() {
		if (this.isMoving)
			return this.meTransform.position;
		return Vector3.zero;
	}
}
