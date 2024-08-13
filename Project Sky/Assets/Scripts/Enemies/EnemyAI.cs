using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
   
[SerializeField] private float enemySpeed; 

private float amplitude = .0025f; 

private float frequency = 3f; 

private float leftBoundary = -15f; 
private float newY; 

private Vector3 newVectorX;
private Vector3 newVectorY;


void Update() {


      newY = transform.position.y + Mathf.Sin(frequency * Time.time) * amplitude;
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


}
