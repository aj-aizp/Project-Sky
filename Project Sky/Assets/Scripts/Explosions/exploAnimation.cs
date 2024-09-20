using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploAnimation : MonoBehaviour
{

    [SerializeField] private Animator anim; 


    private void Awake() {

        float randomNum = Random.Range(0.5f,1.3f); 

        transform.localScale = new Vector3(randomNum, randomNum , 1.0f); 

        anim.Play("Explo"); 

        Destroy(gameObject,.70f);  
    } 
}
