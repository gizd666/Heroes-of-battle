using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameController : MonoBehaviour {
	public bool playert;
	public bool enemyt;
	public float timer = 20;


	// Use this for initialization
	void Start () {
		playert = true;
		enemyt = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.M)) {
			if (playert == (true) & enemyt == (false)) {
				playert = false;
				enemyt = true;
				timer = 20;
			}

		}

		if (enemyt == (true) & playert ==(false)){
			timer -= 1*Time.deltaTime;
			if (timer <= 0){
				playert = true;
				enemyt = false;
			}


		}


	}
}
