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

    private const int LeaderboardLength = 5;
    public List<float> HighScores = new List<float> ();

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        finalscore = PlayerPrefs.GetFloat("finalscore", 0);
        highscoreText.text = "HIGHSCORE: " + highscore.ToString("0.00");
        scoreText.text = "SCORE: " + finalscore.ToString("0.00");
        SaveHighScore(finalscore);
    }


    public void SaveHighScore (float score) {
        int i = 1;
        while (i<=LeaderboardLength && PlayerPrefs.HasKey("HighScore"+i+"score")) {
            score = PlayerPrefs.GetFloat ("finalscore");
            HighScores.Add (score);
            i++;
        }
        if (HighScores.Count == 0) {            
            HighScores.Add (score);
        } else {
            for (i=1; i<=HighScores.Count && i<=LeaderboardLength; i++) {
                if (score > HighScores [i - 1]) {
                    HighScores.Insert (i - 1, score);
                    break;
                }            
                if (i == HighScores.Count && i < LeaderboardLength) {
                    HighScores.Add (score);
                    break;
                }
            }
        }
         
        i = 1;
        while (i<=LeaderboardLength && i<=HighScores.Count) {
            PlayerPrefs.SetFloat ("HighScore" + i + "score", HighScores[i - 1]);
            i++;
        }
         
    }
 
    public float GetHighScore (int i)
    {   
        float rankscore = PlayerPrefs.GetFloat ("HighScore" + i + "score", HighScores[i - 1]); 
        return rankscore;
    }
     
     
    public void OnApplicationQuit() {
        PlayerPrefs.Save();
    }
}
