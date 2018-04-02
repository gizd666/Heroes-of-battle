using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sterowanie : MonoBehaviour {
	public GameObject targetMarker;
	private NavMeshAgent agent;
	public int distance;
	// Use this for initialization
	void Start () {
		

		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {


					agent.destination = targetMarker.transform.position; // nasza postać popierdala do znacznika

	}

	}



