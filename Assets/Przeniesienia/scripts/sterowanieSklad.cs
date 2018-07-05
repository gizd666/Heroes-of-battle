using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class sterowanieSklad : MonoBehaviour {
	private NavMeshAgent agent;
	public GameObject destination;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		agent = GetComponent<NavMeshAgent> ();
		agent.destination = destination.transform.position;
	}
}
