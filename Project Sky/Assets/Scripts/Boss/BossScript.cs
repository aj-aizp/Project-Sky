using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{   
    [SerializeField] private int bossHealth; 

    [SerializeField] private float oscillationSpeed; 

    [SerializeField] private damageFlash damageFlash; 
    [SerializeField] private GameObject exploBox; 

    [SerializeField] private Rigidbody2D rb; 

    [SerializeField] private float downForce; 

    private float randomInt; 

    private void Awake() {
         randomInt = Random.Range(2f,4f); 
    }


private void Update() {

    if(bossHealth <=0) {
        return; 
    }
    
    gameObject.transform.position = new Vector3(gameObject.transform.position.x, randomInt * Mathf.Sin(Time.time * oscillationSpeed ), 0f); 
}


private void OnTriggerEnter2D(Collider2D other) {

if(other.GetComponent<playerBullet>() != null) {
    Destroy(other.gameObject); 
    Damage(); 
}

}


private void Damage() {
    bossHealth-= 10; 

    Messenger.Broadcast(GameEvent.boss_hit_score); 

    damageFlash.CallDamageFlash(); 

     if(bossHealth <=0){
        Death();   
    }
}


private void Death() {

    Messenger.Broadcast(GameEvent.boss_death); 

     exploBox.SetActive(true);  

    rb.AddForce(-transform.up * downForce);   


}

}
