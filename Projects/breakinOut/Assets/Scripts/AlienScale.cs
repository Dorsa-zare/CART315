using UnityEngine;

public class AlienScale : MonoBehaviour
{
    public float scaleSpeed = 2f;  // Speed of scaling
    public float minScale = 0.2f;  // Minimum size
    public float maxScale = 1f;    // Maximum size

    private bool shrinking = true;

    void Update()
    {
        // Calculate new scale
        float scaleChange = scaleSpeed * Time.deltaTime;
        if (shrinking)
        {
            transform.localScale -= new Vector3(scaleChange, scaleChange, 0);
            if (transform.localScale.x <= minScale)
            {
                shrinking = false;
            }
        }
        else
        {
            transform.localScale += new Vector3(scaleChange, scaleChange, 0);
            if (transform.localScale.x >= maxScale)
            {
                shrinking = true;
            }
        }
    }
}