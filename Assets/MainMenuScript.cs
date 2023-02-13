using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public string gameScene;

    private void Awake()
    {
        // Ensure that the gameIsPaused flag is set to false when the scene starts
        pauseMenuScript.gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
        pauseMenuScript.gameIsPaused = false;
    }

    public void toggleAudio()
    {
        // Add audio toggle logic here
    }

    public void openCredits()
    {
        // Add logic to open the credits here
    }

    public void openHighScores()
    {
        // Add logic to open the high scores here
    }
    
}


