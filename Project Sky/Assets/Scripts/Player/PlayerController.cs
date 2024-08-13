using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

[SerializeField] private float playerSpeed; 

[SerializeField] private Rigidbody2D rb; 

private Vector2 movement; 


 void Update() {
    
    float moveUp = Input.GetAxisRaw("Vertical"); 

    float moveDown = Input.GetAxisRaw("Horizontal"); 

    movement = new Vector2(moveDown, moveUp).normalized; 
}

 void FixedUpdate() {
    
        rb.velocity = movement * playerSpeed * Time.deltaTime; 
}





}
