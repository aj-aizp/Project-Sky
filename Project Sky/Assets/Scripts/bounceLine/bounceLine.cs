using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class bounceLine : MonoBehaviour
{

      private void OnTriggerEnter2D(Collider2D other) {

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>(); 

        EnemyBullet pb = other.GetComponent<EnemyBullet>(); 

        if (rb != null && pb != null) {
            rb.velocity = -rb.velocity; 
        }
  }
  
}
