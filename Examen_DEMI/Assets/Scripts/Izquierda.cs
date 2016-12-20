using UnityEngine;
using System.Collections;

public class Izquierda : MonoBehaviour {
	public float velocidad = 70f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			Debug.Log ("Flecha Izquierda");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.left * velocidad);
		}
		
		if (Input.GetKey (KeyCode.S)) {
				Debug.Log ("Flecha Abajo");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.down*velocidad);
		}

		if (Input.GetKey (KeyCode.D)) {
			Debug.Log ("Flecha Derecha");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * velocidad);
		}

		if (Input.GetKey (KeyCode.W)) {
				Debug.Log ("Flecha Arriba");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up*velocidad);
		}
	}
}