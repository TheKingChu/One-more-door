using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShakeScript : MonoBehaviour 
{

	// References to controlled game objects that will fall
	// when you shake the mobile device hard enough
	public GameObject object1, object2, object3, object4;

	// variable to hold shaking acceleration value
	Vector3 accelerationDir;

	// Update is called once per frame
	void Update () 
	{
		
		// Read new acceleration Input from mobile device
		accelerationDir = Input.acceleration;

		// If you shake the mobile device hard enough
		// (accelerations Square Magnitude greater then 5 for example)
		if (accelerationDir.sqrMagnitude >= 5f) 
		{

			// then dishes fall off the shelves getting
			// RigidBodies isKinematic option as false (become Dynamic)
			object1.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
			object2.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
			object3.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
			object4.gameObject.GetComponent<Rigidbody2D> ().isKinematic = false;
		}
	}
}
