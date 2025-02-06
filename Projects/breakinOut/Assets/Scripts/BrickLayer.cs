using UnityEngine;

public class BrickLayer : MonoBehaviour
{
    
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;

    public int numBricks;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lay()
    {
        // Calculate total width and height of grid
        float totalWidth = (columns - 1) * bs_h;
        float totalHeight = (rows - 1) * bs_v;

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                // Adjust positioning to center the grid
                float xPos = (-totalWidth / 2) + (i * bs_h);
                float yPos = this.transform.position.y + (totalHeight / 2) - (j * bs_v);

                Instantiate(brick, new Vector3(xPos, yPos, 0), Quaternion.identity, this.transform);
            }
        }
    }

}
