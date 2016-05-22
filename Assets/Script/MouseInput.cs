using UnityEngine;
using System.Collections;


[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class MouseInput : MonoBehaviour {

	// Use this for initialization

	public GameObject player;

	public float distance = 10;
	public float speed = 120;

	void Start () {
		
	}

	void Update () {

		Vector3 relativePos = player.transform.position - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		transform.rotation = rotation;

	}
}
