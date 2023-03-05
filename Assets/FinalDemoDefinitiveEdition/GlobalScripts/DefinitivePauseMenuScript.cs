using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefinitivePauseMenuScript : MonoBehaviour
{
    // public GameObject level1UI;
    // public GameObject level2UI;
    // public GameObject level3UI;
    // public GameObject level4UI;
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
        // level1UI.SetActive(false);
        // level2UI.SetActive(false);
        // level3UI.SetActive(false);
        // level4UI.SetActive(false);
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
        SceneManager.LoadScene("DefinitiveGameOver");
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
}

