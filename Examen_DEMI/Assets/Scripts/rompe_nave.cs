using UnityEngine;
using System.Collections;

public class rompe_nave : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "piedra") {
			Destroy (gameObject);

		}
	}
}
