﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	[SerializeField]
	private LayerMask clickablesLayer;
	public List<GameObject> selectedObjects;
	[HideInInspector]
	public List<GameObject> selectableObjects;
	private Vector3 mousePos1;
	private Vector3 mousePos2;

	void Awake()
	{
		selectedObjects = new List<GameObject> ();
		selectableObjects = new List<GameObject> ();

	
	}

	// Use this for initialization
	void Start()
	{
		selectedObjects = new List<GameObject> ();	
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (1)) {
			ClearSelection ();
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			mousePos1 = Camera.main.ScreenToViewportPoint (Input.mousePosition);

			RaycastHit rayHit;
			if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity, clickablesLayer))
			{
				ClickOn clickOnScript = rayHit.collider.GetComponent<ClickOn> ();
				if (Input.GetKey ("left ctrl")) 
				{
					if (clickOnScript.currentlySelected == false)
					{
						selectedObjects.Add (rayHit.collider.gameObject);
						clickOnScript.currentlySelected = true;
						clickOnScript.ClickMe ();
					}
				
				else 
				{
						selectedObjects.Remove (rayHit.collider.gameObject);
						clickOnScript.currentlySelected = false;
						clickOnScript.ClickMe ();
				}
				}
				else 
				{
					ClearSelection ();

					selectedObjects.Add (rayHit.collider.gameObject);
					clickOnScript.currentlySelected = true;
					clickOnScript.ClickMe ();

				}
					
			}
	    }

		if (Input.GetMouseButtonUp (0)) {
			mousePos2 = Camera.main.ScreenToViewportPoint (Input.mousePosition);

			if (mousePos1 != mousePos2) {
			
				SelectObjects ();
			}
		
		}
    }
	void SelectObjects()
	{
		List<GameObject> remObject = new List <GameObject> ();

		if (Input.GetKey ("left ctrl") == false)
		{
			ClearSelection ();
		}
		Rect selectRect = new Rect (mousePos1.x, mousePos1.y, mousePos2.x - mousePos1.x, mousePos2.y - mousePos1.y);
		foreach (GameObject selectObject in selectableObjects) 
		{
			if (selectObject != null)
			{
				if (selectRect.Contains(Camera.main.WorldToViewportPoint(selectObject.transform.position), true))
					{
						selectedObjects.Add(selectObject);
						selectObject.GetComponent<ClickOn>().currentlySelected = true;
						selectObject.GetComponent<ClickOn>().ClickMe();
					}
			}
					else
					{
						remObject.Add(selectObject);
					}
		}
					if(remObject.Count > 0)
					{
						foreach(GameObject rem in remObject)
						{
							selectableObjects.Remove(rem);
						}
						remObject.Clear();
					}
	}

	void ClearSelection()
	{
		if (selectedObjects.Count > 0)
	{
		foreach (GameObject obj in selectedObjects)
		{
			obj.GetComponent<ClickOn>().currentlySelected = false;
			obj.GetComponent<ClickOn>().ClickMe ();

		}
		selectedObjects.Clear ();
	}
	}
}