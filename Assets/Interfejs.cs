using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interfejs : MonoBehaviour {
	public Texture tło;
	public float buttonWidth = 300;
	public float buttonHeight = 300;
	public bool on;
	public bool off;

	private float buttonMargin = 20;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F)) {
			if (on == (true) & off == (false)) {
				on = false;
				off = true;
			}
			if (on == (false) & off == (true)) {
				on = true;
				off = false;
			}
		}
	}
	void OnGUI()

	{	
		if (on == (true)){
		GUI.DrawTexture (new Rect (0, 0, 800, 300), tło);

		GUI.Box (new Rect (700, 800, buttonWidth, buttonHeight), "Broń 1"); 
		GUI.Box (new Rect (1100, 800, buttonWidth, buttonHeight), "Broń 2"); 
		GUI.Box (new Rect (1500, 650, 250, 250), "mapa");

	}

}
}