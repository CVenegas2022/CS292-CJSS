using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI highscoreText;
    [Header("Component")]
    [Header("Timer Settings")]
    public float currentTime = 0f;
    public float highscore = 0f;
    public bool countDown;
    private bool shouldUpdate;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        // timerText.text = currentTime.ToString();
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        shouldUpdate=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldUpdate)
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString();
            PlayerPrefs.SetFloat("finalscore", currentTime);
            if (highscore < currentTime)
                PlayerPrefs.SetFloat("highscore", currentTime);
        }
    }

    //Changes shouldUpdate to true if false
    public void toggleShouldUpdateOff()
    {
        if(shouldUpdate)
        {
            shouldUpdate=false;

            highscore = PlayerPrefs.GetFloat("highscore", 0);
            highscoreText.text = "HIGHSCORE: " + highscore.ToString();
            SceneManager.LoadScene("gameOverScreenDemo2-1");
        }
    }
}
