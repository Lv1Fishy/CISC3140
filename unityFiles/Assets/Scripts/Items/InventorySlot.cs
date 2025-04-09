using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler {

    public void OnDrop(PointerEventData eventData) {
        if(transform.childCount == 0) {
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>(); // Get the InventoryItem component from the dragged item
            inventoryItem.parentAfterDrag = transform; // Set the parent of the dragged item to this slot
        }
    }
   
}
