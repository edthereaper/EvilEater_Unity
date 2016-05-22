using UnityEngine;
using System.Collections;

public class RotateTo : MonoBehaviour {

	private Transform meTransform = null;
	public float rotateSpeed = 90f;
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

		this.meTransform.rotation *= 
			Quaternion.AngleAxis (this.rotateSpeed * Time.deltaTime, Vector3.up);
	}
}
