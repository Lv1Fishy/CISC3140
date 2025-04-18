using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler {
    public string slotIndex; // Index of the slot in the inventory
    public bool isEmpty; // Indicates if the slot is empty or not
    public enum slotType {
        BACKPACK,
        INVENTORY,
        HOTBAR
    }

    public slotType type;

    public Item item; // Reference to the item in the slot

    void Update() {
        Item item = GetComponentInChildren<Item>();
        if(transform.childCount == 0) {
            this.item = null;
            isEmpty = true;
        }
        else {
            this.item = item;
            isEmpty = false;
        }
    }
    public void OnDrop(PointerEventData eventData) {
        GameObject dropped = eventData.pointerDrag;
        // Check if the dropped object is null
        if (dropped == null) 
            return;

        Item draggedItem = dropped.GetComponent<Item>();
        // Check if the dragged item is null
        if (draggedItem == null) 
            return;

        // Ensure backpack items can only be placed in backpack slots
        if (draggedItem.type == Item.itemType.BACKPACK && type != slotType.BACKPACK) 
            return;

        // Ensure non-backpack items can only be placed in inventory slots
        if (type == slotType.BACKPACK && draggedItem.type != Item.itemType.BACKPACK) 
            return;

        // If slot is empty, just place it
        if (transform.childCount == 0) {
            draggedItem.parentAfterDrag = transform;
            isEmpty = false;
        } 
        else {
            // Handle swapping logic
            Transform currentItem = transform.GetChild(0);
            Item currentItemScript = currentItem.GetComponent<Item>();

            Transform originalParent = draggedItem.parentAfterDrag;

            currentItem.SetParent(originalParent);
            currentItem.localPosition = Vector3.zero;

            draggedItem.parentAfterDrag = transform;
        }

    }
    
}
