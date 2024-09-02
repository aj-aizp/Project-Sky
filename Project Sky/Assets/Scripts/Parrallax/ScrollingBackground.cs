using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] public float speed; 

    private float length; 
    private Transform cameraTransform; 

    private Vector3 startPosition; 


    void Start() {

        startPosition = transform.position; 
        length = GetComponent<SpriteRenderer>().bounds.size.x; 
        cameraTransform = Camera.main.transform;
    }

    void Update() {

        transform.position += Vector3.left *speed * Time.deltaTime; 

        if(transform.position.x < cameraTransform.position.x - length) {
            RepositionBackground(); 
        }
        
    }


      private void RepositionBackground()
    {
        Vector3 newPosition = new Vector3(transform.position.x + 2 * length, transform.position.y, transform.position.z);
        transform.position = newPosition;
    }





}
