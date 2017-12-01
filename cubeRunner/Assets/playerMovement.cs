using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Update applying physics
	void FixedUpdate () {
		// Multiplying value with the computer frame 
		rb.AddForce (0, 0, 2000 * Time.deltaTime);
	}
}
