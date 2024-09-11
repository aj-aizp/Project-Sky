using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gun : MonoBehaviour
{
   [SerializeField] private GameObject bulletPrefab; 
   [SerializeField] private float projectileSpeed; 
   [SerializeField] private float fireRate; 

   [SerializeField] private Transform gunpoint; 

   private Boolean canShoot = true; 


    private void Update() {
        if (Input.GetMouseButton(0) && canShoot ==true) {

            //Use Coroutine because it will enable me to control timing of shots

            StartCoroutine(Shoot());  

        }


        IEnumerator Shoot() {

            canShoot = false; 

            GameObject bullet = Instantiate(bulletPrefab, gunpoint.position, Quaternion.identity); 

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); 

            rb.velocity = transform.right * projectileSpeed; 
            yield return new WaitForSeconds(fireRate);

            canShoot = true; 

            Destroy(bullet,1f); 
        }
    }



}
