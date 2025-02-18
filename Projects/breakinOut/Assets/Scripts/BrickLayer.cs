using UnityEngine;

public class BrickLayer : MonoBehaviour {
    public GameObject brick;
    public int rows, columns;
    public float bs_h, bs_v;

    public int numBricks; // Number of bricks in the layer

    void Start() {
        Lay();
    }

    void Update() {
        // Check win condition after every brick destruction
        CheckWinCondition();
    }

    public void Lay() {
        float totalWidth = (columns - 1) * bs_h;
        float totalHeight = (rows - 1) * bs_v;

        numBricks = 0;

        for (int i = 0; i < columns; i++) {
            for (int j = 0; j < rows; j++) {
                float xPos = (-totalWidth / 2) + (i * bs_h);
                float yPos = this.transform.position.y + (totalHeight / 2) - (j * bs_v);

                GameObject newBrick = Instantiate(brick, new Vector3(xPos, yPos, 0), Quaternion.identity, this.transform);
                newBrick.GetComponent<AlienBrick>().brickLayer = this;  
                numBricks++;
            }
        }
    }

    public void CheckWinCondition() {
        if (numBricks <= 0 && GameManager.S.timer > 0) {
            // Check if all bricks are destroyed and the timer is still running
            GameManager.S.Win();
        }
    }

    public void BrickDestroyed() {
        numBricks--;
        CheckWinCondition();
    }
}