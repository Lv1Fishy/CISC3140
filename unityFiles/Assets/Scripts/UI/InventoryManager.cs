using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour{

    public List<InventorySlot> inventorySlots; // List of inventory slots


    void Start(){
        // Get the already existing player inventory
        inventorySlots = new List<InventorySlot>(FindObjectsByType<InventorySlot>(FindObjectsSortMode.InstanceID));
        inventorySlots.Sort(sortID);
    }
    int sortID(InventorySlot a, InventorySlot b){
        // Sort the inventory slots by their ID
        return a.slotIndex.CompareTo(b.slotIndex);
    }

    public InventorySlot getEmptySlots(string type){
        // Find the first empty slot in the inventory
        foreach (InventorySlot slot in inventorySlots){
            if (slot.isEmpty){
               return slot;
            }
        }
        return null; // No empty slots found
    }  
}
