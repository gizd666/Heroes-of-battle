using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableCard : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public Transform parentToReturnTo = null;
	public GameObject whatToSpawn;

	public void OnDrag(PointerEventData evData)
	{
		this.transform.position = evData.position;
	}

	public void OnBeginDrag(PointerEventData evData)
	{
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		parentToReturnTo = this.transform.parent;

		this.transform.SetParent (this.transform.parent.parent);

	}

	public void OnEndDrag(PointerEventData evData)
	{
		this.transform.SetParent (parentToReturnTo);
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}
	
	


}
