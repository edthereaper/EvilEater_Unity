using UnityEngine;
using System.Collections;

public class PhysicsMover : MonoBehaviour {

	private CharacterController meCC = null;
	private Mover meMover = null;
	// Use this for initialization
	void Start () {
		this.meCC = GetComponent<CharacterController> ();
		this.meMover = GetComponent<Mover> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		meCC.SimpleMove (this.meMover.GetTransform());
	}
}
