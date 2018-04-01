using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kursor : MonoBehaviour {

	public Texture2D cursorTexture; 
	public Transform postac;
	private int cursorSizeX = 32;
	private int cursorSizeY = 32;
	public GameObject targetMarker;
	//public Rigidbody bullet;

	void Start()
	{
		Cursor.visible = false;
	}
	void Update(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hitInfo;
		if (Physics.Raycast (ray.origin, ray.direction, out hitInfo)) {
			Vector3 targetPosition = new Vector3 (Mathf.Round (hitInfo.point.x), Mathf.Round (hitInfo.point.y), Mathf.Round (hitInfo.point.z));
			Vector3 playerGroundPosition = new Vector3 (postac.transform.position.x, postac.transform.position.y, postac.transform.position.z);
			if (Input.GetMouseButtonDown (1)) {
				targetMarker.transform.position = targetPosition;
				//Vector3 ff = targetMarker.transform.position;
				//	//Rigidbody clone = Instantiate (bullet, postac.transform.position, postac.transform.rotation) as Rigidbody;
				//Vector3 fwd = transform.TransformDirection(ff);
					//clone.AddForce (fwd * 155f);
				}

		}
	}
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Input.mousePosition.x - cursorSizeX / 2, (Screen.height - Input.mousePosition.y) - cursorSizeY / 2, cursorSizeX, cursorSizeY), cursorTexture);
	}
}
