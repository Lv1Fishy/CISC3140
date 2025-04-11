



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {
    
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData) {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData) {
        Debug.Log("Dragging");
        var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        screenPoint.z = 10.0f;
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true; 
    }
   
}
