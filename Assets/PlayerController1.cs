using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

	private Transform playerSelection;
	private bool isSelected;

	void Start () {
		playerSelection = transform.Find ("PlayerSelection");
		isSelected = false;
	}

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

	// Update is called once per frame
	void Update () {
		
	}
}
