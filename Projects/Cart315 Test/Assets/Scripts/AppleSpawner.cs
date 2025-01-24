using UnityEngine;
using System.Collections;
public class AppleSpawner : MonoBehaviour
{

    public bool gameOver = false;
    public GameObject badApplePrefab;
    public GameObject applePrefab;
    public float spawnDelay = 0.5f;

    public float badAppleChance = 0.3f;

    void Start () {
        StartCoroutine(SpawnApple());
    }
    
    IEnumerator SpawnApple () {
        while (!gameOver) {
            GameObject appleToSpawn = GetRandomAppleToSpawn();
            float randomXPosition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(x: randomXPosition, y: 6f, z: 0);
            Instantiate(appleToSpawn, spawnPosition, Quaternion.identity);
            
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    GameObject GetRandomAppleToSpawn()
    {
        float randomXPosition = Random.Range(0f, 1f);
        if (randomXPosition < 0.2f)
        {
            return badApplePrefab;
        } else {
            return applePrefab;

        }
    }
}
 