using UnityEngine;
using System.Collections;

public class impulso_nave : MonoBehaviour {
	public float velocidad = 75f;
	public float giro = 1f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Debug.Log ("Espacio Pulsado");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up*velocidad);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.forward * giro); 
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(Vector3.back * giro); 
		}
	}
}