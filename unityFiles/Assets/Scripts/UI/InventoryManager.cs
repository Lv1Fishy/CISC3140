using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour{

public List<InventorySlot> inventorySlots; // List of inventory slots
[SerializeField] int slotCount = 5; // Number of slots in the inventory


    void Start(){
        // Initialize the inventory slots
        inventorySlots = new List<InventorySlot>();
        for (int i = 0; i < slotCount; i++){
            GameObject slotObject = new GameObject("Slot" + i);
            InventorySlot slot = slotObject.AddComponent<InventorySlot>();
            slot.slotIndex = i.ToString();
            inventorySlots.Add(slot);
        }
    }

    public InventorySlot getEmptyInventorySlots(){
        // Find the first empty slot in the inventory
        foreach (InventorySlot slot in inventorySlots){
            if (slot.isEmpty && slot.type == InventorySlot.slotType.INVENTORY){
                return slot;
            }
        }
        return null; // No empty slots found
    }

    public InventorySlot getEmptyHotbarSlots(){
        // Find the first empty hotbar slot in the inventory
        foreach (InventorySlot slot in inventorySlots){
            if (slot.isEmpty && slot.type == InventorySlot.slotType.HOTBAR){
                return slot;
            }
        }
        return null; // No empty hotbar slots found
    }   

}
