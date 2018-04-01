using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparent : MonoBehaviour {
	private int layerMask = 1 << 8;
	private List<Transform> hiddenObject;
	private GameObject player;

	// Use this for initialization
	void Start () {
		hiddenObject = new List<Transform> ();
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!player)
			return;
		Vector3 direction = player.transform.position - transform.position;
		RaycastHit[] hits = Physics.RaycastAll (transform.position, direction, Mathf.Infinity, layerMask);
		Debug.DrawRay (transform.position, direction, Color.red);
		for (int i = 0; i < hits.Length; i++) {
			RaycastHit hit = hits [i];
			Transform currentHit = hit.transform;
			if (!hiddenObject.Contains (currentHit)) {
				hiddenObject.Add (currentHit);
				Renderer rend = hit.transform.GetComponent<Renderer> ();
				if (rend) {
					rend.material.shader = Shader.Find ("Transparent/Diffuse");
					Color tempColor = rend.material.color;
					tempColor.a = 0.3F;
					rend.material.color = tempColor;
				}
			}
		}
		for (int i = 0; i < hiddenObject.Count; i++) {
			bool isHit = false;
			for (int j = 0; j < hits.Length; j++){
				if(hiddenObject [i] == hits [j].transform){
					isHit = true;
					break;
					}
				}
					if (!isHit) {
						Renderer rend = hiddenObject [i].transform.GetComponent<Renderer>();
						rend.material.shader = Shader.Find("Standard (Specular setup)");
						hiddenObject.RemoveAt(i);
					}
					}
					}
}