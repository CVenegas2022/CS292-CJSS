using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuScript : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public string currentScene;
    private GameObject SoundManager;
    private AudioSource backmusic;


    public void BGM6Off() {
    SoundManager = GameObject.Find("SoundManager");
    backmusic = SoundManager.GetComponent<AudioSource>();
    if(backmusic.isPlaying) backmusic.Pause();
    else backmusic.Play();
    }

    public void WalkSoundOff() {
        GameObject WalkSFX;
        AudioSource soundEffect;

        WalkSFX = GameObject.Find("WalkSFX");
        soundEffect = WalkSFX.GetComponent<AudioSource>();
        if(soundEffect.isPlaying) soundEffect.Pause();
        else soundEffect.Play();
        
    }

    private void Awake()
    {
        // Ensure that the gameIsPaused flag is set to false when the scene starts
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();
                BGM6Off();
                WalkSoundOff();

            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        BGM6Off();
        WalkSoundOff();
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void QuitGame()
    {
        // Application.Quit();
        SceneManager.LoadScene("gameOverScreenDemo2-1");
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}

