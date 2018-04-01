using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Transform playerSelection;
	private bool isSelected;
	public void selectPlayer()
	{
		isSelected = true;
		playerSelection.gameObject.SetActive (true);
	}

	public void unselectPlayer()
	{
		isSelected = false;
		playerSelection.gameObject.SetActive (false);
	}
	// Use this for initialization
	void Start () {
		playerSelection = transform.Find ("PlayerSelection");
		isSelected = false;
	}
			
	// Update is called once per frame
	void Update ()
	{
		
	}
}

