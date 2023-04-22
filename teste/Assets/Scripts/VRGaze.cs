using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VRGaze : MonoBehaviour {

	public Image imgGaze;
	public float totalTime =2;
	public bool gvrStatus;
	public float gvrTime;

	public int distanceOfRay = 10;

	private RaycastHit hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (gvrStatus) {
			gvrTime += Time.deltaTime;

			imgGaze.fillAmount = gvrTime / totalTime;
        }

		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));

		if(Physics.Raycast(ray , out hit, distanceOfRay)) {
			if(imgGaze.fillAmount ==1 && hit.transform.CompareTag("teletransporte"))
			{
				hit.transform.gameObject.GetComponent<Teleporte>().TeleportPlayer();
            }
			if(imgGaze.fillAmount ==1 && hit.transform.CompareTag("RotateCube") && gvrStatus) {
				hit.transform.gameObject.GetComponent<RotateCube>().ChangeSpin();
				gvrStatus = false;
            }
          
        }
	}

	public void GazeON() {

		gvrStatus = true;
    }
	public void GVROFF() {

		gvrStatus = false;
		gvrTime = 0;
		imgGaze.fillAmount = 0;


    }
}
