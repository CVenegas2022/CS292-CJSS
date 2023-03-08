using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    [Header("Component")]
    [Header("Timer Settings")]
    public float highscore = 0f;
    public float finalscore = 0f; 

    private float[] HighScores = new float[] {0, 0, 0, 0, 0};

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        finalscore = PlayerPrefs.GetFloat("finalscore", 0);
        highscoreText.text = "HIGHSCORE: " + highscore.ToString("0.00");
        scoreText.text = "SCORE: " + finalscore.ToString("0.00");
        String temp = "";
        Debug.Log(temp);
        SaveHighScore(finalscore);
        if(highscore != 0) {
            SaveHighScore(highscore);
        }
        for(int i = 0; i < HighScores.Length; i++) {
            temp+=HighScores[i]+"\n";
        }
        Debug.Log(temp);
    }


    public void SaveHighScore (float score) {
        if (score > HighScores[4]) {    
            HighScores[4] = score;       
            Array.Reverse(HighScores);
        } 
        int i = 1;
        while (i <= HighScores.Length) {
            PlayerPrefs.SetFloat ("Rank" + i, HighScores[i - 1]);
            i++;
        }
         
    }
 
    public float GetHighScore (int i)
    {   
        float rankscore = PlayerPrefs.GetFloat ("Rank" + i, 0); 
        return rankscore;
    }
     
     
    public void OnApplicationQuit() {
        PlayerPrefs.Save();
    }
}
