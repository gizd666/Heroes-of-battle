using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Networking;
public class NaPlayer: MonoBehaviour {
	public GameObject targetMarker;
	public GameObject Celownik;
	private NavMeshAgent agent;
	public float stop;
	public float start;
	public float bieganie;
	public float timer = 20;
	public float timers = 2;
	Animator anim;
	public bool dwah;
	public bool move;
	public bool celowanie;
	public int distance;



	void Start () {
		targetMarker = Instantiate (targetMarker, transform.position, transform.rotation) as GameObject;
		targetMarker.SetActive (false);
		Celownik = Instantiate (Celownik, transform.position, transform.rotation) as GameObject;
		Celownik.SetActive (false);
		move = false;
		dwah = false;
		celowanie = false;
		anim = GetComponent<Animator>();



		}

	// Update is called once per frame

	void Update () {
		


		if (Input.GetKeyDown (KeyCode.T)) {  
			dwah = true;
		}
		if (Input.GetKeyDown (KeyCode.Y)) {  
			dwah = false;
		}

		timers -= 1*Time.deltaTime;
		agent = GetComponent<NavMeshAgent> ();




		anim = GetComponent<Animator>();
		if (Input.GetKeyDown (KeyCode.F)) {  //animacja faket
			anim.SetBool ("fuck", true);
			}

		if (Input.GetKeyUp (KeyCode.F)) {
			anim.SetBool ("fuck", false);
		}

		if (Input.GetKey(KeyCode.LeftControl))  // animacja strzał, działa tylko na 2 ręcznej broni
			{
			if (Input.GetMouseButtonDown(0)) {
		
			anim.SetBool ("shoot", true);
			timers = 2;
			
			}
		}
		if (timers < 1){
			anim.SetBool ("shoot", false);
		}
	

		if (dwah == true) {   // animacja trzymania broni 2 ręcznej
			anim.SetBool ("2h", true);
			anim.SetLayerWeight(1, 1);
		}

		if (dwah == false) {
			anim.SetBool ("2h", false);
			anim.SetLayerWeight(1, 0);
		}

		if (Input.GetKeyDown (KeyCode.G)) {   // głupia animacja
			anim.SetBool ("zajeb", true);
		}
		if (Input.GetKeyUp (KeyCode.G)) {
			anim.SetBool ("zajeb", false);
		}
			if (Input.GetKey (KeyCode.C)) {
				move = false;
			}
			timer -= 1*Time.deltaTime; //  animacja - podnoszenie
			if (Input.GetKey (KeyCode.E)) {
				anim.SetBool ("pick", true);
				timer = 2;
			}
			if (timer < 2){
				anim.SetBool ("pick", false);
			}

						
			if (agent.remainingDistance <= 1) {  // kasowanie znacznika, gdzie postać idzie gdy dystans jest mniejszy niż 1
				move = false;
				targetMarker.SetActive (false);
			}
			if (celowanie == true) {
				targetMarker.SetActive (false);
			}
			if (move == false){     // animacja - idle
				 
				anim.SetFloat ("speed", stop);

			}
			if (move == true){ //animacja - walk
				anim.SetFloat ("speed", start);

			}
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			anim.SetBool ("cel", true);
		}
			if (move == true) { // animacja - run
				if (Input.GetKey (KeyCode.LeftShift)) {
					
					anim.SetFloat ("speed", bieganie);
				}
			}
			if (celowanie == false) {
				
				if (Input.GetMouseButton (0)) {
				agent.angularSpeed = 1000f; 
					Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);  // promień kamera-pozycja myszy
					RaycastHit hitInfo;
					if (Physics.Raycast (ray.origin, ray.direction, out hitInfo)) { // promień jebnął w coś czy nie ^
						if (hitInfo.transform.gameObject.tag != "Player" && hitInfo.transform.gameObject.tag != "Enemy") { // Tagi, ale nam to nie jest potrzebne w co jebnął tutaj, na razie zostaje
							Vector3 targetPosition = new Vector3 (Mathf.Round (hitInfo.point.x), Mathf.Round (hitInfo.point.y), Mathf.Round (hitInfo.point.z)); // pozycja znacznika
							Vector3 playerGroundPosition = new Vector3 (transform.position.x, (transform.position.y - agent.height * 2 / 3), transform.position.z); // pozycja nóg naszej postaci
							int moveCost = (int)Mathf.Round (Vector3.Distance (targetPosition, playerGroundPosition)); // koszt ruchu (dla tury z punktami akcji, ale nie mamy tego)
							int distance = (int)Mathf.Round (Vector3.Distance (targetPosition, playerGroundPosition)); // dystans między postacią a znacznikiem


								move = true; // to jest
								
						
								targetMarker.transform.position = targetPosition; // przeniesienie klocka na pozycje kursora
								targetMarker.SetActive (true);

								agent.destination = targetMarker.transform.position; // nasza postać popierdala do znacznika

							}

							
						}

				
					}

				}
			
			// włączanie celowania
			if (Input.GetKey (KeyCode.LeftControl)) {
			

				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);  // promień kamera-pozycja myszy
				RaycastHit hitInfo;
				if (Physics.Raycast (ray.origin, ray.direction, out hitInfo)) { // promień jebnął w coś czy nie ^
					if (hitInfo.transform.gameObject.tag != "Player" && hitInfo.transform.gameObject.tag != "Enemy") { // Tagi, ale nam to nie jest potrzebne w co jebnął tutaj, na razie zostaje
						Vector3 targetPosition = new Vector3 (Mathf.Round (hitInfo.point.x), Mathf.Round (hitInfo.point.y), Mathf.Round (hitInfo.point.z)); // pozycja znacznika
						Vector3 playerGroundPosition = new Vector3 (transform.position.x, (transform.position.y - agent.height * 2 / 3), transform.position.z); // pozycja nóg naszej postaci

						int distance = (int)Mathf.Round (Vector3.Distance (targetPosition, playerGroundPosition)); // dystans między postacią a celownikiem

						Celownik.transform.position = targetPosition; // przeniesienie celownika na pozycje kursora
						Celownik.SetActive (true);


					var lookPos = targetPosition - transform.position;  
					lookPos.y = 0;  //zablokowanie osi y (żeby postać widziała znacznik na ziemi)
					  							
				
					var rotation = Quaternion.LookRotation(lookPos);  //obrót postaci w kierunku znacznika
					transform.rotation = Quaternion.Slerp(transform.rotation, rotation,Time.deltaTime * 10);
					
					celowanie = true;
					agent.destination = transform.position; // zatrzymywanie postaci

					}
			
				}
			}
			// wyłączanie celowanie
			if (Input.GetKeyUp (KeyCode.LeftControl)) {
				celowanie = false;
				Celownik.SetActive (false);
			    anim.SetBool ("cel", false);
			    agent.angularSpeed = 10f; 
			}
			if (Vector3.Distance (transform.position, targetMarker.transform.position) < 1.0001f) { // usuwanie znacznika przy 1 jednostce 
				targetMarker.SetActive (false);
			}
		}
}
	


