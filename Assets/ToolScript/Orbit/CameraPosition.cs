using UnityEngine;
using System.Collections;

public class CameraPosition : MonoBehaviour {

	// Use this for initialization
	public Transform orbitTransform = null;

	void Awake () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = this.orbitTransform.position;
		this.transform.rotation = this.orbitTransform.rotation;
	}
}
