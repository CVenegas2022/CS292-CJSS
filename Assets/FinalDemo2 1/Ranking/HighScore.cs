using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    private const int LeaderboardLength = 5;
    public List<float> HighScores = new List<float> ();

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
     
    /*
    public void ClearLeaderBoard () {
        //for(int i=0;i<HighScores.
        List<float> HighScores = GetHighScore();
         
        for(int i=1;i<=HighScores.Count;i++) {
            PlayerPrefs.DeleteKey("HighScore" + i + "score");
        }
    }
    */
     
     void OnApplicationQuit() {
        PlayerPrefs.Save();
    }
}
