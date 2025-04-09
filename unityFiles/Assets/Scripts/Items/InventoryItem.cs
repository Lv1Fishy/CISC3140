


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    
    [Header("UI")]
    public Image image;
    
    [HideInInspector] public Transform parentAfterDrag;
    [HideInInspector] public Items item;
    private void InitialiseItem(Items newItem) {
        item = newItem; // Assign the item to the current instance
        image.sprite = newItem.image; // Set the icon sprite to the item's sprite
    }

    public void OnBeginDrag(PointerEventData eventData) {
        image.raycastTarget = false; // Disable raycast target to allow dragging
        parentAfterDrag = transform.parent; // Store the parent transform before dragging
        transform.SetParent(transform.root); // Set the parent to the root to allow free movement
    }

    public void OnDrag(PointerEventData eventData){
        transform.position = Input.mousePosition; // Update the position of the item to follow the mouse cursor
    }

    public void OnEndDrag(PointerEventData eventData){
        image.raycastTarget = true; // Re-enable raycast target after dragging
        transform.SetParent(parentAfterDrag); // Set the parent back to the original parent
    }
    
}
