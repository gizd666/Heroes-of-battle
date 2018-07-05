using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class sterowanie : MonoBehaviour {
	private NavMeshAgent agent;
	private Vector3 destination;
	public GameObject targetMarker;
	Animator anim;

	public float tpx;
	public float tpy;
	public float tpz;
	public float tpp;
	public float tppc;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		targetMarker = Instantiate (targetMarker, transform.position, transform.rotation) as GameObject;
		targetMarker.SetActive (false);
		anim.SetBool ("move", false);
		anim.SetBool ("attack", false);



	}
	
	// Update is called once per frame
	void Update () {
		anim = GetComponent<Animator> ();

		
		agent = GetComponent<NavMeshAgent> ();
		ClickOn clickOnScript = GetComponent<ClickOn> ();
		Click clickScript = Camera.main.GetComponent<Click> ();
			if (clickOnScript.currentlySelected == true) {
			
			if(Input.GetMouseButtonDown(0)){
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);  // promień kamera-pozycja myszy
				RaycastHit hitInfo;
				if (Physics.Raycast (ray.origin, ray.direction, out hitInfo)) { // promień jebnął w coś czy nie ^

					Vector3 targetPosition = new Vector3 (Mathf.Round (hitInfo.point.x), Mathf.Round (hitInfo.point.y), Mathf.Round (hitInfo.point.z));
				
				targetMarker.SetActive (true);
					anim.SetBool ("move", true);
					tppc = clickScript.selectedObjects.IndexOf (gameObject);

					if (tppc <= 5) {
						tpp = clickScript.selectedObjects.IndexOf (gameObject) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z;
					}

					if (tppc <= 10 && tppc >5) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -5)*3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-3;
					}

					if (tppc <= 15 && tppc >10) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -10) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-6;
					}

					if (tppc <= 20 && tppc >15) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -15) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-9;
					}

					if (tppc < 25 && tppc >20) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -20) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-12;
					}

					if (tppc < 30 && tppc >25) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -25) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-15;
					}

					if (tppc < 35 && tppc >30) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -30) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-18;
					}

					if (tppc < 40 && tppc >35) {
						tpp = (clickScript.selectedObjects.IndexOf (gameObject) -35) * 3;
						tpx = targetPosition.x + tpp;
						tpy = targetPosition.y;
						tpz = targetPosition.z-21;
					}

					Vector3 tmp = new Vector3 (tpx, tpy, tpz);

					targetMarker.transform.position = tmp;










						
					agent.destination = tmp;
			}
			}
		}
			if (Vector3.Distance (transform.position, targetMarker.transform.position) < 2.0001f) { // usuwanie znacznika przy 1 jednostce 
				targetMarker.SetActive (false);
			    anim.SetBool ("move", false);
		}
		if(clickOnScript.currentlySelected == false){
					targetMarker.SetActive (false);
				}
				}}