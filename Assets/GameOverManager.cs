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
        int p = 1;
        while (p <= HighScores.Length) {
            HighScores[p-1] = PlayerPrefs.GetFloat ("Rank" + p, HighScores[p - 1]);
            p++;
        }
        for(int i = 0; i < HighScores.Length; i++) {
            temp+=HighScores[i]+"\n";
        }
        Debug.Log(temp);
        if(highscore != 0 && highscore != HighScores[0]) {
            SaveHighScore(highscore);
        }
        SaveHighScore(finalscore);
        for(int i = 0; i < HighScores.Length; i++) {
            temp+=HighScores[i]+"\n";
        }
        Debug.Log(temp);
    }


    public void SaveHighScore (float score) {
        HighScores[0] = PlayerPrefs.GetFloat ("Rank" + 1, 0);
        HighScores[1] = PlayerPrefs.GetFloat ("Rank" + 2, 0);
        HighScores[2] = PlayerPrefs.GetFloat ("Rank" + 3, 0);
        HighScores[3] = PlayerPrefs.GetFloat ("Rank" + 4, 0);
        HighScores[4] = PlayerPrefs.GetFloat ("Rank" + 5, 0);
        
        if (HighScores[0] != score | HighScores[1] != score | HighScores[2] != score | HighScores[3] != score | HighScores[4] != score) {
            if (score > HighScores[4]) {    
            HighScores[4] = score;       
            Array.Sort(HighScores);
            Array.Reverse(HighScores);
            } 
        }
        
        for (int j = 0; j < HighScores.Length-1; j++) {
            for (int k = j+1; k < HighScores.Length; k++) {
                if(HighScores[j] == HighScores[k]) {
                    HighScores[k] = 0;
                    Array.Sort(HighScores);
                    Array.Reverse(HighScores);
                }
            }
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
