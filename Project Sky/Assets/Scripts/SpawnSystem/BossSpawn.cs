using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{

       [SerializeField] private BoxCollider2D bc; 

      [SerializeField] private GameObject bossFab; 

      private int deadBossNum = 0; 

      public int currentBossNum = 1; 



public Vector2 getRandomPoint() {

    Bounds bounds = bc.bounds; 

    float randomX = Random.Range(bounds.min.x, bounds.max.x); 
    float randomY = Random.Range(bounds.min.y, bounds.max.y);

    return new Vector2(randomX,randomY); 
}


    private void OnEnable() {
        
          Messenger.AddListener(GameEvent.boss_death,bossSpawn); 
    }

    private void OnDisable() {
        Messenger.RemoveListener(GameEvent.boss_death,bossSpawn); 
    }


    private void bossSpawn(){

        deadBossNum += 1; 

        if (deadBossNum == currentBossNum) {

            spawnPlease();
        }
    }

    private void spawnPlease(){

        int k = 0;  
        
        for (int i = 1; i <= currentBossNum; i++) {
            StartCoroutine(spawnB());  
            k += 1; 
        }

         currentBossNum += k;   

        Debug.Log(currentBossNum);  
    }

    IEnumerator spawnB () {

        Instantiate(bossFab, getRandomPoint(), Quaternion.identity); 

         yield return new WaitForSeconds(100f); 

    }
}
