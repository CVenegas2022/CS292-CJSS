using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{/*
    private static HighScoreManager m_instance;
    private const int LeaderboardLength = 10;
     
    public static HighScoreManager _instance {
        get {
            if (m_instance == null) {
                m_instance = new GameObject ("HighScoreManager").AddComponent<HighScoreManager> ();                
            }
            return m_instance;
        }
    }
     
    void Awake () {
        if (m_instance == null) {
            m_instance = ts;            
        } else if (m_instance != ts)        
            Destroy (gameObject);    
         
        DontDestroyOnLoad (gameObject);
    }

    public void SaveHighScore (int score) {
        List<Scores> HighScores = new List<Scores> ();
 
        int i = 1;
        while (i<=LeaderboardLength && PlayerPrefs.HasKey("HighScore"+i+"score")) {
            Scores temp = new Scores ();
            temp.score = PlayerPrefs.GetInt ("HighScore" + i + "score");
            HighScores.Add (temp);
            i++;
        }
        if (HighScores.Count == 0) {            
            Scores _temp = new Scores ();
            _temp.score = score;
            HighScores.Add (_temp);
        } else {
            for (i=1; i<=HighScores.Count && i<=LeaderboardLength; i++) {
                if (score > HighScores [i - 1].score) {
                    Scores _temp = new Scores ();
                    _temp.score = score;
                    HighScores.Insert (i - 1, _temp);
                    break;
                }            
                if (i == HighScores.Count && i < LeaderboardLength) {
                    Scores _temp = new Scores ();
                    _temp.score = score;
                    HighScores.Add (_temp);
                    break;
                }
            }
        }
         
        i = 1;
        while (i<=LeaderboardLength && i<=HighScores.Count) {
            PlayerPrefs.SetInt ("HighScore" + i + "score", HighScores [i - 1].score);
            i++;
        }
         
    }
 
    public List<Scores>  GetHighScore ()
    {
        List<Scores> HighScores = new List<Scores> ();
 
        int i = 1;
        while (i<=LeaderboardLength && PlayerPrefs.HasKey("HighScore"+i+"score")) {
            Scores temp = new Scores ();
            temp.score = PlayerPrefs.GetInt ("HighScore" + i + "score");
            HighScores.Add (temp);
            i++;
        }
 
        return HighScores;
    }
     
    public void ClearLeaderBoard () {
        //for(int i=0;i<HighScores.
        List<Scores> HighScores = GetHighScore();
         
        for(int i=1;i<=HighScores.Count;i++) {
            PlayerPrefs.DeleteKey("HighScore" + i + "score");
        }
    }
     
     void OnApplicationQuit() {
        PlayerPrefs.Save();
    }
    */
}
 /*
 public class Scores {
    public int score;
 }
 */
