using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosinEnemy : MonoBehaviour
{
      
[SerializeField] private float enemySpeed; 
 [SerializeField] private damageFlash damageFlash; 

 [SerializeField] private float enemyHealth;  

 [SerializeField] private Rigidbody2D rb; 

 [SerializeField] private float downForce; 

private float amplitude = .01f; 

private float frequency = 3f; 

private float leftBoundary = -20f; 
private float newY; 

private Vector3 newVectorX;
private Vector3 newVectorY;


void Update() {

      newY = transform.position.y + Mathf.Cos(frequency * Time.time) * amplitude;
      newVectorY = new Vector3 (0f, newY,0f) ; 
    
     //Vector3.left is shorthand for (-1,0,0) 
      newVectorX.x = transform.position.x + (-1 * enemySpeed * Time.deltaTime); 

    transform.position = newVectorX + newVectorY;  

    Debug.Log(transform.position); 
    }

void FixedUpdate() {

    if(transform.position.x < leftBoundary) {
        Destroy(gameObject); 
    }
}

private void OnTriggerEnter2D(Collider2D other) {

if(other.GetComponent<playerBullet>() != null) {
    Destroy(other.gameObject); 
    Damage(); 
}
}

private void Damage() {
    enemyHealth-= 10; 

    if(enemyHealth <=0) {
        Death(); 
    }

     Messenger.Broadcast(GameEvent.enemy_hit_score); 


    damageFlash.CallDamageFlash(); 
}


private void Death() {

    Messenger.Broadcast(GameEvent.enemy_down_score); 

    rb.AddForce(-transform.up * downForce);    
}


}
