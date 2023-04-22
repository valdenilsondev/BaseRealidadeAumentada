using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
public class movimentacaoPlayer : MonoBehaviour {

	public GameObject Quad;
	public int lengthX = 70;
	public int lengthZ = 70;

	public float offSetX = 0.5f;
	public float offSetZ = 0.5f;

	[Range(0.01f, 0.2f)]
	public float height = 0.1f;

	private Vector3 posInit;



	
	
	
	// Use this for initialization
	void Start () {

		posInit = new Vector3(this.transform.position.x-20, this.transform.position.y + height, this.transform.position.z-20);

		for(int x = 0; x < lengthX; x ++) {

			for(int z =0; z < lengthZ; z++) {
				GameObject quadriculado = Instantiate(Quad);

				quadriculado.name = "PlayerPosition";
				quadriculado.transform.tag = "AllowerPosition";

				quadriculado.transform.position = new Vector3(posInit.x + x + offSetX, posInit.y, posInit.z + z + offSetZ);

				quadriculado.transform.parent = this.transform;
            }


        }



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
