using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


	private GameObject[] mercenaries;
	// Use this for initialization
	void Start () {
		mercenaries = GameObject.FindGameObjectsWithTag("Player");
	}

	public void unselectAll()	{
		foreach (GameObject player in mercenaries) {
			player.GetComponent<PlayerController> ().unselectPlayer ();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
