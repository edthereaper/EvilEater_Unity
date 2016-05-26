using UnityEngine;
using System.Collections;

public class GizmoDirection : MonoBehaviour {

	public bool hide = false; // show or hide
	public string iconName = ""; // help to identify the Gizmo
	public Transform ownerTransform = null;

	// meters scale
	[Range(0f, 20f)]
	public float range = 10f;

	// overload native funcion
	// only work in scene 
	void OnDrawGizmos() {

		if (hide) {
			return;
		}

		// show me position
		Gizmos.DrawIcon (this.transform.position, this.iconName, true);

		// draw Color Sphere
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere (this.transform.position, this.range);

		// draw where is forward 
		Gizmos.color = Color.blue;
		Gizmos.DrawLine (this.transform.position, this.transform.position - this.ownerTransform.forward * this.range);

	}

}
