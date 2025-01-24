using System;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public int value = 1;
    private float bottomY = -6f;
    void Update() {
        if (transform.position.y < bottomY) {
            Destroy(gameObject);
        }
    }
}
