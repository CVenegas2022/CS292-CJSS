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
    private float[] ranking = new float[5];
    public float highscore = PlayerPrefs.GetFloat("highscore", 0);
    public float finalscore = PlayerPrefs.GetFloat("finalscore", 0);

    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "HIGHSCORE: " + highscore.ToString("0.00");
        scoreText.text = "SCORE: " + finalscore.ToString("0.00");
    }

    void InsertRank(int finalscore) {
        for(int i = 0; i < 5; i++) {
            if(finalscore > PlayerPrefs.Get(i.ToString())) {
                for(int j = 4-i; j > 0; j--) {
                    PlayerPrefs.SetInt(j.ToString().PlayerPrefs.GetInt((j-1).ToString()));
                }
                PlayerPrefs.SetInt(i.ToString(), finalscore);
                break;
            }
        }
    }

    void RankingSet(float finalscore) {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        finalscore = PlayerPrefs.GetFloat("finalscore", 0);

        for(int i = 0; i < 5; i++) {
            ranking[i] = PlayerPrefs.GetFloat(i + "highscore");

            while(highscore[i] < finalscore)
        }
       
    }
}
