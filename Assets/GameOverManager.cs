using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    [Header("Component")]
    [Header("Timer Settings")]
    public float highscore = 0f;
    public float finalscore = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        finalscore = PlayerPrefs.GetFloat("finalscore", 0);
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
        scoreText.text = "SCORE: " + finalscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
