

/******************************************************

    PLAYER SCRIPT
    HANDLES MOVEMENT, CHARACTER STATS, PLAYER INVENTORY

*******************************************************/


using UnityEngine;

public class PlayerScript : MonoBehaviour {
    
    [SerializeField] int HP;
    [SerializeField] float movementSpeed = 5;


    [SerializeField] Rigidbody2D body;

    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    
    void Update() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        body.linearVelocity = new Vector2(moveHorizontal * movementSpeed, moveVertical * movementSpeed);
        
    }
    
    void FixedUpdate(){
        
    }

}
