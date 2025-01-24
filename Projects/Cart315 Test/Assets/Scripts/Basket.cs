using UnityEngine;
using TMPro; // Import TMPro
public class Basket : MonoBehaviour
{

    public bool gameOver = false;
    public int score = 0;
    public TMP_Text scoreText;
    private void Update()
    {

        if (!gameOver) {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float mouseX = Mathf.Clamp(mousePosition.x, -7.5f, 7.5f);
            transform.position = new Vector3(mouseX, transform.position.y, transform.position.z); 
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!gameOver)
        {
            int appleValue = collision.GetComponent<Apple>().value;
            score += appleValue;
            score = Mathf.Clamp(score, 0, int.MaxValue);
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);   
        }
       
    }
}
