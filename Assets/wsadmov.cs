using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wsadmov : MonoBehaviour {

	// Use this for initialization
	public float sp;
	public float se;

	Animator anim;


	void Start () {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W))
		{
			anim.SetFloat ("speed", se);
		}
		else
		{
			anim.SetFloat ("speed", sp);
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetBool ("prawo", true);
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			anim.SetBool ("prawo", false);
		}
	}
}