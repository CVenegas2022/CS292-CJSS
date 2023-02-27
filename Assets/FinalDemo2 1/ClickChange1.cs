using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickChange1 : MonoBehaviour
{
    // private GameObject AudioManager;
    // private AudioSource backmusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMainMenu() {
        // Debug.Log("Changing to the titleScreen(2)");
        SceneManager.LoadScene("titleScreenDemo2-1");
        GameObject AudioManager;
        AudioManager = GameObject.Find("AudioManager");
        AudioSource backmusic = AudioManager.GetComponent<AudioSource>();
        backmusic.Play();
    }

    public void OnClickRestart() {
        // Debug.Log("Changing to the restartScreen");
        SceneManager.LoadScene("DemoScene2-1");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
