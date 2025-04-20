

/******************************************************

    PLAYER SCRIPT
    HANDLES MOVEMENT, CHARACTER STATS, PLAYER INVENTORY

*******************************************************/


using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    
    [SerializeField] int HP;
    [SerializeField] float movementSpeed = 10f;


    [SerializeField] Rigidbody2D body;
    [SerializeField] GameObject inventoryUI; // Reference to the inventory UI object
    [SerializeField] PersistentData instance; // Reference to the PersistentData instance
    [SerializeField] bool isInventoryOpen; // Flag to check if the inventory is open
    void Start() {
        //Setting up Player Stats
        HP = instance.getCurrentHealth(); // Get the current health from the PersistentData instance
        body = GetComponent<Rigidbody2D>();
        inventoryUI = GameObject.FindGameObjectWithTag("Inventory"); // Find the inventory UI object by tag
        inventoryUI.transform.position += new Vector3(9999, 9999, 0); // Hide the inventory UI at the start
        isInventoryOpen = false; // Set the inventory open flag to false
    }

    
    void Update() {
        PlayerMovement();   //Checks for player input and moves the player accordingly
        checkInventory();   // Check for inventory input
        
    }
    
    void FixedUpdate(){
        
    }

    /*
    * PlayerMovement() - Handles player movement based on input
    */
    void PlayerMovement() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        body.linearVelocity = new Vector2(moveHorizontal * movementSpeed, moveVertical * movementSpeed);
    }

    /*
    * Handles Opening and Closing the Inventory
    */
    void checkInventory() {
        if (Input.GetKeyDown(KeyCode.B)) { // Check if the "B" key is pressed
            if (isInventoryOpen) {
                inventoryUI.transform.position += new Vector3(9999, 9999, 0);
                isInventoryOpen = false; 
            } 
            else {
                inventoryUI.transform.position -= new Vector3(9999, 9999, 0); 
                isInventoryOpen = true;
            }
        }
    }

}
