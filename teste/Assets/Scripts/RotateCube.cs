using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {


	bool rotacionar;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (rotacionar) {
			transform.Rotate(new Vector3(0, 1, 0));
			
		}
	}

	public void ChangeSpin() {

		if (rotacionar == false) {
			rotacionar = true;
		
		}else if(rotacionar == true) {

			rotacionar = false;
        }
    }

	public void StopChangeSpin() {

		rotacionar = false;
	}
}
