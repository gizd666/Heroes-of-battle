using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otwieranieskrzynek : MonoBehaviour {
	private NaPlayer gracz;
	private float timer = 0;
	private GameObject turaGracza;
	private GameObject turaPrzeciwnika;


	// Use this for initialization
	void Start () {
		gracz = GetComponent<NaPlayer> ();

	}
	
	// Update is called once per frame
	void Update () {
					timer += Time.deltaTime;
		Time.maximumDeltaTime = 102;
		if (timer > 100);
		Debug.Log ("hello");
	
			
				
		}
		
}
