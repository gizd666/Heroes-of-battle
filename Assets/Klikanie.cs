using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Klikanie : MonoBehaviour {
	public GameObject targetMarker;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);  // promień kamera-pozycja myszy
			RaycastHit hitInfo;
			if (Physics.Raycast (ray.origin, ray.direction, out hitInfo)) { // promień jebnął w coś czy nie ^
				if (hitInfo.transform.gameObject.tag != "Player" && hitInfo.transform.gameObject.tag != "Enemy") { // Tagi, ale nam to nie jest potrzebne w co jebnął tutaj, na razie zostaje

					Vector3 targetPosition = new Vector3 (Mathf.Round (hitInfo.point.x), Mathf.Round (hitInfo.point.y), Mathf.Round (hitInfo.point.z)); // pozycja znacznika






					targetMarker.transform.position = targetPosition; // przeniesienie klocka na pozycje kursora
					targetMarker.SetActive (true);

					 // nasza postać popierdala do znacznika
	}
			}
		}
	}}

