using UnityEngine;
using System.Collections;

public class Cohete : MonoBehaviour {
	public float fuerza = 100f;
	public float giro = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			Debug.Log ("Espacio Pulsado");
			GetComponent<Rigidbody2D> ().AddForce (transform.right*fuerza);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.forward * giro); 
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate(Vector3.back * giro); 
		}
	}
}