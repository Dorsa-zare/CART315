using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagement : MonoBehaviour
{
    public int points;
    public int lives = 3;
    
    public static GameManagement S;

    // awake happens before start
    void Awake()
    {
       S = this; 
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoseLife()
    {
        lives -= 1;
        if (lives <= 0) GameOver();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void AddPoint()
    {
        points += 1;
    }
}
