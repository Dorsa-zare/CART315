using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public int lives;
    public int points;
    public float timer = 60f; // Total time for the game (60 seconds)

    public Text gameOverText;
    public Text winText; // Text to show when the player wins

    public static GameManager S;

    void Awake() {
        S = this;
    }

    void Start() {
        lives = 4;
        Time.timeScale = 1; // Ensure game runs normally at start

        if (gameOverText != null) {
            gameOverText.gameObject.SetActive(false);
        }
        if (winText != null) {
            winText.gameObject.SetActive(false);
        }
    }

    void Update() {
        if (timer > 0) {
            timer -= Time.deltaTime;  // Decrease timer over time
        } else {
            if (!winText.gameObject.activeSelf && !gameOverText.gameObject.activeSelf) {
                ShowGameOver();
            }
        }
    }

    // **Win Condition (All Bricks Destroyed)**
    public void Win() {
        if (winText != null) {
            winText.text = "Yay! You Win!";
            winText.gameObject.SetActive(true);
        }
        Debug.Log("You Win!");
        Time.timeScale = 0; // **Pause the game**
    }

    // **Lose Condition (Game Over)**
    public void ShowGameOver() {
        if (gameOverText != null) {
            gameOverText.text = "Game Over!";
            gameOverText.gameObject.SetActive(true);
        }
        Debug.Log("Game Over!");
        Time.timeScale = 0; // **Pause the game**
    }
    
}