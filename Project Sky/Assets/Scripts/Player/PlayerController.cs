using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

[SerializeField] private float playerSpeed; 

[SerializeField] private Rigidbody2D rb;  

[SerializeField] private int playerHealth; 

private Vector2 movement; 



 void Update() {
    
    float moveUp = Input.GetAxisRaw("Vertical"); 

    float moveDown = Input.GetAxisRaw("Horizontal"); 

    movement = new Vector2(moveDown, moveUp).normalized; 
}

 void FixedUpdate() {
    
        rb.velocity = movement * playerSpeed * Time.deltaTime; 
}


private void OnTriggerEnter2D(Collider2D other) {
    
if(other.GetComponent<EnemyBullet>() != null) {
    Destroy(other.gameObject); 
    Damage(); 
}
   
  }
private void Damage() {
    playerHealth-= 10; 

    Messenger.Broadcast("player_health_down"); 
}

}
