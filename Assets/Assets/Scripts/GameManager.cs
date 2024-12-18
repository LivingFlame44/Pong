using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public string levelName;
    //variables that holds the score value
    public int p1Score;
    public int p2Score;
    //this variables will display the score on screen
    public Text txtP1Score;
    public Text txtP2Score;
    public static bool isThereAnyBricks;
    public Text txtMessage;
    public GameObject winPanel;

    public int maxScore;
    // Update is called once per frame
    void Update()
    {
        if (levelName == "Pong")
        {
            txtP1Score.text = PlayerPrefs.GetInt("p1Score", 0).ToString();
            txtP2Score.text = PlayerPrefs.GetInt("p2Score", 0).ToString();
            if (PlayerPrefs.GetInt("p1Score", 0) == maxScore)
            {
                txtMessage.text = "P1 Win";
                Time.timeScale = 0;
                winPanel.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("p2Score", 0) == maxScore)
            {
                txtMessage.text = "P2 Win";
                Time.timeScale = 0;
                winPanel.SetActive(true);
            }
        }
        if (levelName == "Ricochet")
        {
            if (isThereAnyBricks)
            {
                Debug.Log("win");
                winPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
