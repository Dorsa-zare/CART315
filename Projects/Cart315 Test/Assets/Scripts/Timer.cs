using UnityEngine;
using System.Collections;
using TMPro; // Import TMPro
using UnityEngine.SceneManagement;
using UnityEngine.UI;  
public class Timer : MonoBehaviour
{
    public Basket basket;
    public AppleSpawner appleSpawner;

    public int gameDuration = 60;

    public TMP_Text highscoreText;
    public TMP_Text timerText;

    public TMP_Text finalScoreText;
    public TMP_Text finalHighScoreText;

    public GameObject gameOverScreen;
    
    public Button restartButton;  // Assign this in the Inspector

    private void Start()
    {
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        StartCoroutine(CountdownTimer());
        restartButton.onClick.AddListener(Restart);
    }
    void OnGameOver()
    {
        //Stop the player from moving
        basket.gameOver = true;
        
        //Stop the apples from spawning
        appleSpawner.gameOver = true;
        
        //Set high score
        int currentHighscore = PlayerPrefs.GetInt("Highscore");
        if (currentHighscore < basket.score) {
            PlayerPrefs.SetInt("Highscore", basket.score);
           highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
        }
        
        finalScoreText.text = "score: " + basket.score;
        finalHighScoreText.text = "High Score: " + PlayerPrefs.GetInt("Highscore");
        // Activate game over screen
        gameOverScreen.SetActive(true);
    }

    IEnumerator CountdownTimer()
    {
        for (int i = gameDuration; i >= 0; i--)
        {
            gameDuration = i;
            
            string minutes = Mathf.Floor(gameDuration / 60).ToString("00");
            string seconds = (gameDuration % 60).ToString("00");
            
            timerText.text = minutes + ":" + seconds;
            
            yield return new WaitForSeconds(1);
        }
        OnGameOver();
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

