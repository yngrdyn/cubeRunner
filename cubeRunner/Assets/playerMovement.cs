using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 1000f;
	public float sidewaysForce = 500f;

	// Update applying physics
	void FixedUpdate () {
		// Multiplying value with the computer frame 
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d")){
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0);
		}

		if(Input.GetKey("a")){
			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0);
		}

	}
}
