using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        // Move bullet upwards
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet hit: " + other.gameObject.name); // This will show what the bullet touches

        if (other.CompareTag("Brick"))  
        {
            Debug.Log("Hit an Alien!");
            Destroy(other.gameObject); // Destroy Alien
            Destroy(gameObject); // Destroy Bullet
        }
    }

}