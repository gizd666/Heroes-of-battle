using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startsklad : MonoBehaviour {
	public GameObject targetMarker;
	// Use this for initialization
	void Start () {
		targetMarker = Instantiate (targetMarker, transform.position, transform.rotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
