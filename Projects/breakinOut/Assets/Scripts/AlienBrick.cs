using UnityEngine;

public class AlienBrick : MonoBehaviour
{
    public BrickLayer brickLayer;  // Reference to BrickLayer

    void OnDestroy()
    {
        if (brickLayer != null)
        {
            brickLayer.BrickDestroyed();  // Inform BrickLayer that a brick was destroyed
        }
    }
}