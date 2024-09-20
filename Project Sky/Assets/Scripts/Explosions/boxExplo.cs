using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxExplo : MonoBehaviour
{

    [SerializeField] private BoxCollider2D bc; 

    [SerializeField] private GameObject exploFab; 

    public float spawnRate = 0.1f;

    private void Update() {
        
        StartCoroutine(exploSpawn()); 
    }


public Vector2 getRandomPoint() {

    Bounds bounds = bc.bounds; 

    float randomX = Random.Range(bounds.min.x, bounds.max.x); 
    float randomY = Random.Range(bounds.min.y, bounds.max.y);

    return new Vector2(randomX,randomY); 
}

IEnumerator exploSpawn() {

    Vector2 ranVec2 = getRandomPoint(); 

    Instantiate(exploFab, ranVec2,Quaternion.identity); 

    yield return new WaitForSeconds(spawnRate); 

}


}
