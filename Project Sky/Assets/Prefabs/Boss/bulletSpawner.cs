using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{

    [Header("bullet settings")]
    public GameObject bulletPrefab;  // Bullet prefab to spawn
    public float spawnRate = 0.1f;   // Time between each bullet spawn
    public float bulletSpeed = 5f;   // Speed at which bullets move
    public float rotationSpeed = 50f; // Speed of rotation for the helix

    public float waveFrequency = 2f; 

    private float angle = 0f;

    void Start()
    {
        // Start the coroutine to spawn bullets
        StartCoroutine(SpawnBullets());
    }

    IEnumerator SpawnBullets()
    {
        while (true)
        {
            SpawnBullet();
           // SpawnWave(); 
            yield return new WaitForSeconds(spawnRate);

        }
    }

    void SpawnBullet()
    {
        // Calculate the direction of the bullet using angle
        float x = Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = Mathf.Sin(angle * Mathf.Deg2Rad);
        Vector3 direction = new Vector3(x, y, 0);

        // Instantiate the bullet
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // Set bullet velocity
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = -direction * bulletSpeed;
        }

        // Increment the angle for the next bullet
        angle += 2.0f * rotationSpeed * Time.deltaTime;
    }

    void SpawnWave() {

    float angle = Mathf.Sin(Time.time * waveFrequency) * 45f; // Adjust amplitude for wider wave

    float x = Mathf.Cos(angle * Mathf.Deg2Rad);
    float y = Mathf.Sin(angle * Mathf.Deg2Rad);
    Vector3 direction = new Vector3(x, y, 0);

    GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
    if (rb != null)
    {
        rb.velocity = -direction * bulletSpeed;
    }

    } 



}
