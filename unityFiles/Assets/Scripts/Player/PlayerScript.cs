

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
    void Start() {
        //Setting up Player Stats
        HP = instance.getCurrentHealth(); // Get the current health from the PersistentData instance
        



        body = GetComponent<Rigidbody2D>();

        inventoryUI = GameObject.FindGameObjectWithTag("Inventory"); // Find the inventory UI object by tag
        inventoryUI.SetActive(false); // Hide the inventory UI at the start
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
            if (inventoryUI.activeSelf) {
                closeInventory(); // Close the inventory if it's already open
            } else {
                openInventory(); // Open the inventory if it's closed
            }
        }
    }
    void openInventory() {
        inventoryUI.SetActive(true); // Show the inventory UI when the player presses the "B" key
    }
    void closeInventory() {
        inventoryUI.SetActive(false); // Hide the inventory UI when the player presses the "B" key again
    }

}
