using UnityEngine;
using System.Collections;


public class OrbitTo : MonoBehaviour {

	public Transform pivotTransform = null;
	private Transform meTransform = null;
	private Quaternion destRot = Quaternion.identity;
	// distance from the pivot
	public float pivotDistance = 5f;
	public float rotSpeed = 10f;

	private float rotX = 0f;
	private float rotY = 0f;

	private float prevMouseX = 0f;
	private float prevMouseY = 0f;


	// Use this for initialization
	void Awake () {
		this.meTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {

		float horz = (Input.mousePosition.x - Screen.width / 2) / Screen.width;
		float vert = (Input.mousePosition.y - Screen.height / 2) / Screen.height;

		if (this.prevMouseX != horz || this.prevMouseY != vert) {
//			
//			float rateMouseX = horz - this.prevMouseX;
//			float rateMouseY = vert - this.prevMouseY;
//			 
//			this.rotX = rateMouseX * Time.deltaTime * this.rotSpeed;
//			this.rotY = rateMouseY * Time.deltaTime * this.rotSpeed;

			this.rotX += horz * Time.deltaTime * this.rotSpeed;
			this.rotY += vert * Time.deltaTime * this.rotSpeed;

			Quaternion yRot = Quaternion.Euler (0, this.rotY, 0);
			this.destRot = yRot * Quaternion.Euler (this.rotX, 0, 0);

			this.meTransform.rotation = this.destRot;

			this.meTransform.position = 
				this.pivotTransform.transform.position +
				this.meTransform.rotation *
				Vector3.up *
				-this.pivotDistance;
	
			this.prevMouseX = horz;
			this.prevMouseY = vert;
//
		}
	}
}
