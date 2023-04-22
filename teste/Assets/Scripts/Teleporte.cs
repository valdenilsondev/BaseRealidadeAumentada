using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporte : MonoBehaviour {


	public GameObject player;


	public void TeleportPlayer() {

		player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
