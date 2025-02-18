using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour {
    public GameObject alienStonePrefab; 
    private GameObject[] bricks; 

    public float minThrowTime = 1f;  // Min time between throws
    public float maxThrowTime = 3f;  // Max time between throws

    void Start() {
        StartCoroutine(ThrowStones());
    }

    IEnumerator ThrowStones() {
        while (true) {
            yield return new WaitForSeconds(Random.Range(minThrowTime, maxThrowTime));

            bricks = GameObject.FindGameObjectsWithTag("Brick");  // Get all bricks

            if (bricks.Length > 0) {
                GameObject randomBrick = bricks[Random.Range(0, bricks.Length)];  
                Instantiate(alienStonePrefab, randomBrick.transform.position, Quaternion.identity);
            }
        }
    }
}