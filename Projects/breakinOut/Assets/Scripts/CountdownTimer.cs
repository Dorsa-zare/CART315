using UnityEngine;
using UnityEngine.UI;  // For UI elements

public class CountdownTimer : MonoBehaviour
{
    public Text timerText;  // UI Text to display the timer
    public float startTime = 60f;  // Start time in seconds (1 minute)

    private float currentTime;

    void Start()
    {
        currentTime = startTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        // Decrease the time only if it is greater than zero
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;  // Decrease time by the time passed since last frame
            UpdateTimerDisplay();
        }
        else
        {
            // Timer is finished
            timerText.text = "Time's Up!";
        }
    }

    // Update the displayed timer text
    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);  // Get minutes
        int seconds = Mathf.FloorToInt(currentTime % 60);  // Get seconds

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);  // Format to show as MM:SS
    }
}