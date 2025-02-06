using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutPaddle : MonoBehaviour
{
    private float xPos;
    public float paddleSpeed = .05f;
    public float leftWall, rightWall;

    public KeyCode leftKey, rightKey;
    
    // variables for shooting
    public Transform firePoint;   // FirePoint to spawn bullets
    public GameObject bulletPrefab; // Bullet prefab

    void Update()
    {
        // Paddle Movement
        if (Input.GetKey(leftKey))
        {
            if (xPos > leftWall)
            {
                xPos -= paddleSpeed;
            }
        }

        if (Input.GetKey(rightKey))
        {
            if (xPos < rightWall)
            {
                xPos += paddleSpeed;
            }
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);

        // Shooting
        if (Input.GetKeyDown(KeyCode.Space)) // Press Space to shoot
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}