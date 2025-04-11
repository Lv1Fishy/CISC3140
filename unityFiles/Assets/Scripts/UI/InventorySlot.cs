using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler {
    public string slotIndex; // Index of the slot in the inventory

    public void OnDrop(PointerEventData eventData){
        if(transform.childCount == 0) {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;
        }
    }
}
