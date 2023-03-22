using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    public PaddleMovement paddle;
    public GameObject[] lives;
    int life = 3;
    
    void OnCollisionEnter2D(Collision2D other) 
    {
       if(other.gameObject.tag =="Ground")
       {
         CheckLife();
         ball.ResetBall();
         paddle.ResetPaddle();
       }    
    }

   void CheckLife()
   {
      life--;
      Destroy(lives[life].gameObject);
      
      if(life==0)
      {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         Debug.Log("Scene Reloaded");
      }   
   }
    
}
