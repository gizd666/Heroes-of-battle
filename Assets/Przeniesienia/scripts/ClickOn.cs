using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour {
	[SerializeField]
	private Material red;
	[SerializeField]
	private Material green;

	private MeshRenderer myRend;
	[HideInInspector]
	public bool currentlySelected = false;

	// Use this for initialization
	void Start () {
		myRend = GetComponent<MeshRenderer> ();
		Camera.main.gameObject.GetComponent<Click> ().selectableObjects.Add (this.gameObject);
		ClickMe ();
	}
	public void ClickMe()
	{
		if (currentlySelected == false) {
			myRend.material = red;
		} 
		else
		{
			myRend.material = green;
		}
	    
	}
}
