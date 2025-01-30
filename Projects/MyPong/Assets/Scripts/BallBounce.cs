using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
   public GameObject hitSFX;
   public BallMovement ballMovement;
   public ScoreManager scoreManager;
   public Player1 player1; // Reference to Player 1
   public Player2 player2; // Reference to Player 2

   private void Bounce(Collision2D collision)
   {
      Vector3 ballPosition = transform.position;
      Vector3 racketPosition = collision.transform.position;
      float racketHeight = collision.collider.bounds.size.y;

      float positionX;
      if(collision.gameObject.name == "Player 1")
      {
         positionX = 1;
      }
      else
      {
         positionX = -1;
      }

      float positionY = (ballPosition.y - racketPosition.y) / racketHeight;
      
      ballMovement.IncreaseHitCounter();
      ballMovement.MoveBall(new Vector2(positionX, positionY));
   }

   private void OnCollisionEnter2D(Collision2D collision)
   {
      Debug.Log("Collided with: " + collision.gameObject.name);  // Check what the ball is colliding with

      if (collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
      {
         Bounce(collision);  // Continue with racket bounce behavior
      }
      else if (collision.gameObject.name == "Right Border")
      {
         scoreManager.Player1Goal();
         ballMovement.player1Start = false;
         StartCoroutine(ballMovement.Launch());
      }
      else if (collision.gameObject.name == "Left Border")
      {
         scoreManager.Player2Goal();
         ballMovement.player1Start = true;
         StartCoroutine(ballMovement.Launch());
      }
      else if (collision.gameObject.CompareTag("YellowSquare")) // Ball hits Yellow Square
      {
         StartCoroutine(SlowDownPlayer(player2)); 
         
         // Destroy the yellow square
         Destroy(collision.gameObject);  
      }
      else if (collision.gameObject.CompareTag("PurpleSquare")) // Ball hits Purple Square
      {
         StartCoroutine(SlowDownPlayer(player1)); 
         
         // Destroy the purple square
         Destroy(collision.gameObject); 
      }

      Instantiate(hitSFX, transform.position, transform.rotation);  // Hit sound effect
   }




   IEnumerator SlowDownPlayer(Player1 player)
   {
      Debug.Log("Slowing down Player1");  // Debug message to check if it's being called
      float originalSpeed = player.racketSpeed;
      player.racketSpeed *= 0.1f;  // Slow down the player 

      // Wait for 5 seconds before restoring the speed
      yield return new WaitForSeconds(10);

      player.racketSpeed = originalSpeed;  // Restore original speed
      Debug.Log("Player1 speed restored");  // Check if speed is being restored
   }


   IEnumerator SlowDownPlayer(Player2 player)
   {
      Debug.Log("Slowing down Player2");  // Debug message to check if it's being called
      float originalSpeed = player.racketSpeed;
      player.racketSpeed *= 0.1f;  // Slow down the player

      // Wait for 5 seconds before restoring the speed
      yield return new WaitForSeconds(10);

      player.racketSpeed = originalSpeed;  // Restore original speed
      Debug.Log("Player2 speed restored");  // Check if speed is being restored
   }

}
