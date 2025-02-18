using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienStone : MonoBehaviour
{
    public float fallSpeed = 5f; // control how fast the stone falls

    void Start()
    {
    }

    void Update()
    {
        // If the stone has gravity
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }

    // Handle collision with the paddle
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Debug.Log("Stone hit the paddle!");
            
            // Show the Game Over text
            GameManager.S.ShowGameOver();
            
            // Destroy the stone when it hits the paddle
            Destroy(gameObject);
        }
    }

    // Handle collision with the walls
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Stone hit the wall!");
            Destroy(gameObject); // Destroy the stone when it hits the wall
        }
    }
}