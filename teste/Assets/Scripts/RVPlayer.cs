using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RVPlayer : MonoBehaviour {


	public Camera cameraRayCast;
	public float speed = 0.7f;
	public int distanceToMove = 10;
	public GameObject arrowToMove;
	public AudioClip clickASound;

	private AudioSource audioSource;

	private RaycastHit hit;
	private Vector3 starPoint;
	private Vector3 endPoint;
	private float starTime;
	private float jorneyLength;
	private bool flagStop = false;



//	public GameObject painelInformacao;

	public GameObject nome;

	public float tempoesperar;
	// Use this for initialization
	void Start () {

		audioSource = GetComponent<AudioSource>();


	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = cameraRayCast.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

		if (Physics.Raycast(ray, out hit, distanceToMove)) {

			float scaleArrow = Vector3.Distance(hit.transform.position, this.transform.position) / 13000;

			arrowToMove.transform.localScale = new Vector3(scaleArrow, scaleArrow, scaleArrow);
			arrowToMove.transform.position = hit.transform.position;
        }

        if (Input.GetMouseButtonDown(0)) {

			if(Physics.Raycast(ray, out hit, distanceToMove)) {

				if(hit.transform.tag == "AllowerPosition") {

					audioSource.clip = clickASound;
					audioSource.Play();

					starPoint = transform.position;

					endPoint = hit.transform.position;

					starTime = Time.time;

					jorneyLength = Vector3.Distance(starPoint, endPoint);

					flagStop = true;
                }



            }
        }

        if (flagStop) {

			float distConverd = (Time.time - starTime) * speed;

			float fracJourney = distConverd / jorneyLength;

			Vector3 move = Vector3.Lerp(starPoint, endPoint, fracJourney);

			this.transform.position = move;


			if(this.transform.position == endPoint) {


				flagStop = false;
            }


        }



	}

	public void painelInfo() {

		audioSource.clip = clickASound;
		audioSource.Play();

		starPoint = transform.position;

		endPoint = hit.transform.position;

		starTime = Time.time;

		jorneyLength = Vector3.Distance(starPoint, endPoint);

		flagStop = true;


	}
}
