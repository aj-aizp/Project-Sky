using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private BoxCollider2D bc; 

    [SerializeField] private GameObject enemy; 

    [SerializeField] private GameObject cosEnemy; 

    public float spawnRate;

    private int ranNum; 



       private void Update() {
        
        ranNum = Random.Range(0,10000); 

        if(ranNum <=10) {
        StartCoroutine(enemySpawn()); 
        }

        if(  ranNum <= 90 && ranNum >= 60) {

        StartCoroutine(CosEnemySpawn()); }   
    } 


    public Vector2 getRandomPoint() {

    Bounds bounds = bc.bounds; 

    float randomX = Random.Range(bounds.min.x, bounds.max.x); 
    float randomY = Random.Range(bounds.min.y, bounds.max.y);

    return new Vector2(randomX,randomY); 
}



IEnumerator enemySpawn() {

    Vector2 ranVec2 = getRandomPoint(); 

    Instantiate(enemy, ranVec2,Quaternion.identity); 

    yield return new WaitForSeconds(spawnRate); 
}

IEnumerator CosEnemySpawn() {

    Vector2 ranVec2 = getRandomPoint(); 

    Instantiate(cosEnemy, ranVec2,Quaternion.identity); 

    yield return new WaitForSeconds(spawnRate); 



}





}
