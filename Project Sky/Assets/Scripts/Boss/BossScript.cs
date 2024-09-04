using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{   
    [SerializeField] private int bossHealth; 

    [SerializeField] private float oscillationSpeed; 
 

private void Update() {
    gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4 * Mathf.Sin(Time.time * oscillationSpeed ), 0f); 
}


private void OnTriggerEnter2D(Collider2D other) {

if(other.GetComponent<playerBullet>() != null) {
    Destroy(other.gameObject); 
    Damage(); 
}

}


private void Damage() {
    bossHealth-= 10; 
}

}
