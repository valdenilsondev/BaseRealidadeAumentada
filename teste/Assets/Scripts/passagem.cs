using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passagem : MonoBehaviour {

	private RVPlayer player;
	private Vector3 posInit;

	
	// Use this for initialization
	void Start () {

		player = FindObjectOfType<RVPlayer>();

		posInit = player.transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GeTInBuid() {

		posInit = player.transform.position;

		player.transform.position = this.transform.position;

    }

	public void GetOutBuild() {

		player.transform.position = posInit;
    }
}
