using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {


	public float maxSpeed = 10f;
	public float rotSpeed = 100f;
	public bool isMoving = false;

	private CharacterController characterController = null;

	// Use this for initialization
	void Start () {
		this.characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			if (Input.GetKey ("w")) {
				this.transform.position += this.transform.forward * (Time.deltaTime * this.maxSpeed);
			}
			if (Input.GetKey ("s")) {
				this.transform.position += -this.transform.forward * (Time.deltaTime * this.maxSpeed);
			}
			if (Input.GetKey ("a")) {
				this.transform.position += Vector3.left * (Time.deltaTime * this.maxSpeed);
			}
			if (Input.GetKey ("d")) {
				this.transform.position += Vector3.right * (Time.deltaTime * maxSpeed);
			}
			if (Input.GetKey ("e")) {
				this.transform.Rotate (Vector3.up * Time.deltaTime * rotSpeed);
			}
			if (Input.GetKey ("q")) {
				this.transform.Rotate (-Vector3.up * Time.deltaTime * rotSpeed);
			}
			this.isMoving = true;
		} else {
			this.isMoving = false;
		}
	}
}
