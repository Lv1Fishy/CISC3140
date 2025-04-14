using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler {
    public string slotIndex; // Index of the slot in the inventory
    public enum slotType {
        BACKPACK,
        INVENTORY,
        NEARBY
    }

    public slotType type;

    public void OnDrop(PointerEventData eventData){
        GameObject dropped = eventData.pointerDrag;
        if(dropped == null) 
            return;
 
        Item draggedItem = dropped.GetComponent<Item>();
        if(draggedItem == null) 
            return;

        // Ensure backpack items can only be placed in backpack slots
        if(draggedItem.type == Item.itemType.BACKPACK && type != slotType.BACKPACK) 
            return;

        if(type == slotType.BACKPACK && draggedItem.type != Item.itemType.BACKPACK) 
            return;

        // If slot is empty, just place it
        if(transform.childCount == 0) {
            draggedItem.parentAfterDrag = transform;
        }
        else {
            // Get the item currently in the slot
            Transform currentItem = transform.GetChild(0);
            Item currentItemScript = currentItem.GetComponent<Item>();

            // Swap the items' parent transforms
            Transform originalParent = draggedItem.parentAfterDrag;
            
            // Move the current item back to the original slot of the dragged item
            currentItem.SetParent(originalParent);
            currentItem.localPosition = Vector3.zero;

            // Move the dragged item to this slot
            draggedItem.parentAfterDrag = transform;
        }
    }
}
