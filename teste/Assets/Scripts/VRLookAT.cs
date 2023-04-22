using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookAT : MonoBehaviour {


	public Transform vrCamera;
	public float targetAngle =30.0f;
	public float speed =3.0f;
	public bool moveFoward;

	private CharacterController controller;



	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {


		if (vrCamera.eulerAngles.x >= targetAngle && vrCamera.eulerAngles.x < 90.0f) {
			moveFoward = true;

		}
        else {
			moveFoward = false;
		}

        if (moveFoward) {

			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

			controller.SimpleMove(forward *speed) ;
        }

			


	}
}
