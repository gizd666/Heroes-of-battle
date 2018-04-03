using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	private GameController gc;
	// Use this for initialization
	void Start () {
		gc = GameObject.Find ("GameController").GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)){ 
			Ray ray = gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)) {
				if (hit.transform.gameObject.tag == "Player") {
					Transform selected = hit.transform;
					gc.unselectAll ();
					selected.SendMessage ("selectPlayer");
				}
			}
	}
	}
}
