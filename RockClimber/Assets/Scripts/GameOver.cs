using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //Restart and Quit buttons in the game over menu. Restart is loading according to the name of the scene.


    public static bool gameOver;
    public GameObject gameOverPanel;
    void Start()
    {
        gameOver = false;
    }

    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 1;
            gameOverPanel.SetActive(true);
        }
    }
    public void LoadScene(string _name)
    {
        SceneManager.LoadScene(_name);

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
