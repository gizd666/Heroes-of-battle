using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacja : MonoBehaviour {
	
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			anim.SetBool ("attack", true);
		}

		if (Input.GetKey (KeyCode.S)) {
			anim.SetBool ("attack", false);
		}


		if (Input.GetKey (KeyCode.X)) {
			anim.SetBool ("move", true);
		}

		if (Input.GetKey (KeyCode.C)) {
			anim.SetBool ("move", false);
		}
	}
}
