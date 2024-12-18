using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public string sceneName;
    public GameObject levelsPanel;
    public GameObject pausePanel;
  
    // Start is called before the first frame update
    private void Start()
    {
     
    }
    public void ButtonReset()
    {
        Breakables.noOfBricks = 0;
        GameManager.isThereAnyBricks = false;
        Time.timeScale = 1;
        PlayerPrefs.DeleteKey("p2Score");
        PlayerPrefs.DeleteKey("p1Score");
        SceneManager.LoadScene(sceneName);   
    }
    public void MenuButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.DeleteKey("p2Score");
        PlayerPrefs.DeleteKey("p1Score");
    }
    
    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void RicochetBut()
    {
        Time.timeScale = 1;
        levelsPanel.SetActive(true);
    }
    public void BackBut()
    {
        levelsPanel.SetActive(false);
    }

    public void PauseBut()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeBut()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void RetryBut()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
