using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefinitiveMainMenuScript : MonoBehaviour
{
    public string gameScene;
    public string creditScene;
    public GameObject AudioManager;
    public AudioSource backmusic;

    private void Awake()
    {
        // Ensure that the gameIsPaused flag is set to false when the scene starts
        pauseMenuScript.gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        if(Input.GetKey("1"))
        {
             gameScene="EED2_Scene02";
        }
        else if(Input.GetKey("2"))
        {
            gameScene="EED2_Scene01";
        }
        else if(Input.GetKey("up") || Input.GetKey("down"))
        {
            gameScene="EEFlipScene";
        }
        else if(Input.GetKey("left") || Input.GetKey("right"))
        {
            gameScene="EEMirrorScene";
        }
        else if(Input.GetKey("left ctrl"))
        {
            gameScene="EEMoonJumpScene";
        }
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
        pauseMenuScript.gameIsPaused = false;
    }

    public void toggleAudio()
    {
        // Add audio toggle logic here
    }

    public void openCredits()
    {
         SceneManager.LoadScene(creditScene);
    }

    public void openRanking()
    {
        SceneManager.LoadScene("RankingSystem");
    }

    public void openHighScores()
    {
        // Add logic to open the high scores here
    }

    public void openTutorial() {
        SceneManager.LoadScene("tutorial1");
    }

     public void BGM1Button() {
        AudioManager = GameObject.Find("AudioManager");
        backmusic = AudioManager.GetComponent<AudioSource>();
        if(backmusic.isPlaying) backmusic.Pause();
        else backmusic.Play();
    }

    
}


