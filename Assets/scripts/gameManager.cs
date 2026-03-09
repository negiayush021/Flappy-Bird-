using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject StartGameCanvas;
    public static gameManager instance;
    public GameObject GameOverCanvas;
   // public GameObject Bird;

    private void Awake()
    {
        instance = this;
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        Audio.instance.PlayClip(4);
        StartGameCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    
}
