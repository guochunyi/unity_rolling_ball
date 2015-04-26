using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;	
	private Rigidbody rb;


	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		float Horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (Horizontal, 0.0f, vertical);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			//Destroy(other.gameObject);
			other.gameObject.SetActive(false);
		}
	}
}
