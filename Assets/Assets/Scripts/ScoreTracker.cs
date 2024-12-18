using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    public GameManager gameManager;
    public int whatWall; //this identifies w/c wall the ball hits
    public void OnCollisionEnter2D(Collision2D actor)
    {
        //increments the score depending on w/c wall the ball hits
        if (actor.gameObject.CompareTag("Ball"))
        {
            switch (whatWall)
            {
                case 1:
                    gameManager.p1Score += 1;
                    PlayerPrefs.SetInt("p1Score", PlayerPrefs.GetInt("p1Score", 0) + 1);
                    if (PlayerPrefs.GetInt("p1Score", 0) != gameManager.maxScore)
                    {
                        SceneManager.LoadScene("Pong");
                    }
                    break;
                case 2:
                    gameManager.p2Score += 1;
                    PlayerPrefs.SetInt("p2Score", PlayerPrefs.GetInt("p2Score", 0) + 1);
                    if (PlayerPrefs.GetInt("p2Score", 2) != gameManager.maxScore)
                    {
                        SceneManager.LoadScene("Pong");
                    }
                    
                    break;
            }
        }
    }
}
