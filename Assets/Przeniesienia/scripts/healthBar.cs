using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour {
	public int asd;
	public int health;
	public int maxHealth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI()
	{

		Vector2 targetPos;
		targetPos = Camera.main.WorldToViewportPoint (transform.position);

		GUI.Box(new Rect(targetPos.x, targetPos.y, 60, 20), health + "/" + maxHealth);

	}

}
