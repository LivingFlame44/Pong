using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject ball;
    public GameObject paddlePlayer1;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D actor)
    {
        if (actor.gameObject.CompareTag("Ball"))
        {
            Time.timeScale = 0;
            ball.gameObject.SetActive(false);
            paddlePlayer1.gameObject.SetActive(false);
            gameOverPanel.gameObject.SetActive(true);
        }
    }
}