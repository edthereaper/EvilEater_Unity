using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	//meters / second
	public float maxSpeed = 0.05f;
	private Transform meTransform = null;

	// initialize all variable
	void Awake() {
		this.meTransform = GetComponent<Transform> ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Time.deltatime help to correct speed and movement of the GameObject
		//in differect arquitectures of pc
		this.meTransform.position += this.meTransform.forward * this.maxSpeed * Time.deltaTime;
	}
}
