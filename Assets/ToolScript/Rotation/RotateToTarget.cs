using UnityEngine;
using System.Collections;

public class RotateToTarget : MonoBehaviour {

	private Transform meTransform = null;

	public float rotateSpeed = 90f;
	public GameObject target = null;
	public bool available = false;

	// Use this for initialization
	void Awake () {
		this.meTransform = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {

		if (!available) {
			return;
		}

		// ************** Rotate inmidiattly to target position ************

//		Quaternion destRot = Quaternion.LookRotation (this.meTransform.position - this.target.transform.position,
//			Vector3.up);
//		this.meTransform.rotation = destRot;

		// *************** with thist code, the gameobject rotate with time delta progress *********

		Quaternion destRot = Quaternion.LookRotation (this.meTransform.position - this.target.transform.position,
			Vector3.up);
		this.meTransform.rotation = Quaternion.RotateTowards (this.meTransform.rotation,
			destRot,
			this.rotateSpeed * Time.deltaTime);
			
	}
		
}
