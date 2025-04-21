using System;
using UnityEngine;

public class SpriteItem : MonoBehaviour {

    public Item item;
    public InventoryManager manager;
    public GameObject obj;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        obj = GameObject.FindGameObjectWithTag("InventoryManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Player")) {
            // Check if the player has an empty inventory slot
            InventorySlot slot = obj.GetComponent<InventoryManager>().getEmptySlots(item.type.ToString());
            item = Instantiate(item); // Instantiate the item
            if(slot.isEmpty) {
                item.parentAfterDrag = slot.transform;
                item.transform.SetParent(slot.transform);
                item.transform.localPosition = Vector3.zero; // Reset position within the slot
                item.transform.localScale = new Vector3(0.6f, 0.6f, 1); // Reset scale within the slot
                Destroy(gameObject); // Destroy the original item after pickup
            }
        }
    }

}

