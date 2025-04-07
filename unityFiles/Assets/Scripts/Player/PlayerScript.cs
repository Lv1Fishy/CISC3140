

/******************************************************

    PLAYER SCRIPT
    HANDLES MOVEMENT, CHARACTER STATS, PLAYER INVENTORY

*******************************************************/


using UnityEngine;

public class PlayerScript : MonoBehaviour {
    
    [SerializeField] int HP;
    [SerializeField] float movementSpeed = 10f;


    [SerializeField] Rigidbody2D body;

    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    
    void Update() {
        PlayerMovement();   //Checks for player input and moves the player accordingly
        
        
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
}
