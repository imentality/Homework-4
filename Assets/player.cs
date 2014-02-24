using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public int zAxis = 1;
	public int xAxis = 1;
	public int distance = 5000;
	public int pRotation = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( pRotation == 0 ) {
			if( Input.GetKeyDown( KeyCode.W ) ) {
				rigidbody.AddForce (0, 0, distance);
			}
			if( Input.GetKeyDown( KeyCode.S ) ) {
				rigidbody.AddForce (0, 0, -distance );
			}
			if( Input.GetKeyDown( KeyCode.D ) ) {
				rigidbody.AddForce (distance, 0, 0);
			}
			if( Input.GetKeyDown( KeyCode.A ) ) {
				rigidbody.AddForce (-distance, 0, 0);
			}
		}
		else if( pRotation == 90 ) {
			if( Input.GetKeyDown( KeyCode.W ) ) {
				rigidbody.AddForce (distance, 0, 0);
			}
			if( Input.GetKeyDown( KeyCode.S ) ) {
				rigidbody.AddForce (-distance, 0, 0);
			}
			if( Input.GetKeyDown( KeyCode.D ) ) {
				rigidbody.AddForce (0, 0, -distance);
			}
			if( Input.GetKeyDown( KeyCode.A ) ) {
				rigidbody.AddForce (0, 0, distance);
			}
		}
		else if( pRotation == 180 ) {
			if( Input.GetKeyDown( KeyCode.W ) ) {
				rigidbody.AddForce (0, 0, -distance);
			}
			if( Input.GetKeyDown( KeyCode.S ) ) {
				rigidbody.AddForce (0, 0, distance );
			}
			if( Input.GetKeyDown( KeyCode.D ) ) {
				rigidbody.AddForce (-distance, 0, 0);
			}
			if( Input.GetKeyDown( KeyCode.A ) ) {
				rigidbody.AddForce (distance, 0, 0);
			}
		}
		else if( pRotation == 270 ) {
			if( Input.GetKeyDown( KeyCode.W ) ) {
				rigidbody.AddForce (-distance, 0, 0);
			}
			if( Input.GetKeyDown( KeyCode.S ) ) {
				rigidbody.AddForce (distance, 0, 0);
			}
			if( Input.GetKeyDown( KeyCode.D ) ) {
				rigidbody.AddForce (0, 0, distance);
			}
			if( Input.GetKeyDown( KeyCode.A ) ) {
				rigidbody.AddForce (0, 0, -distance);
			}
		}


		if( Input.GetKeyDown( KeyCode.E ) ) {
			transform.Rotate (0, 90, 0);
			pRotation += 90;
			if( pRotation >= 360 ) {
				pRotation -= 360;
			}
		}
		if( Input.GetKeyDown( KeyCode.Q ) ) {
			transform.Rotate (0, -90, 0);
			pRotation += 270;
			if( pRotation >= 360 ) {
				pRotation -= 360;
			}
		}
		if( Input.GetKeyDown( KeyCode.Space ) ) {
			rigidbody.AddForce (0, distance, 0);
		}
		if (Input.GetKeyDown (KeyCode.X)) {
			rigidbody.AddForce (0, -distance, 0);
		}
	}
}
