



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Item : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {
    
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    public String itemName;
    public String itemDescription;
    public int itemID;


    public enum itemType {
        CONSUMABLE,
        THROWABLE,
        BACKPACK
    }

    public itemType type;

    public void OnBeginDrag(PointerEventData eventData) {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData) {
        Vector3 screenPoint = Input.mousePosition;
        screenPoint.z = 10f; // Set this appropriately depending on your canvas setup
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

    public void OnPointerClick(PointerEventData eventData) {
        if (eventData.button == PointerEventData.InputButton.Left && Input.GetKey(KeyCode.LeftShift)) {
            
        }
    }

    public void OnEndDrag(PointerEventData eventData) {
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
   
}
