using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    [SerializeField] private float oscillationSpeed; 
 

private void Update() {
    gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4 * Mathf.Sin(Time.time * oscillationSpeed ), 0f); 
}

}
