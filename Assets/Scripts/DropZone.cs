using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class DropZone : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IDropHandler {

	public void OnDrop(PointerEventData evPointerData)
	{
	//	evPointerData.pointerDrag.GetComponent<DraggableCard> ().whatToSpawn
	
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
             RaycastHit hit;
             if (Physics.Raycast (ray, out hit)) 
             {
                 //draw invisible ray cast/vector
                 Debug.DrawLine (ray.origin, hit.point);
                 //log hit area to the console
                 Debug.Log(hit.point);
                                   
             } 
		
	
	
		//Debug.Log(Camera.main.ScreenToViewportPoint(Input.mousePosition));
		Instantiate(evPointerData.pointerDrag.GetComponent<DraggableCard> ().whatToSpawn, 
		hit.point, Quaternion.identity);
		
		
	}

	public void OnPointerEnter(PointerEventData evPointerData)
	{
		
	}
	
	public void OnPointerExit(PointerEventData evPointerData)
	{
		
	}
}
