using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomClass : MonoBehaviour {
    public HighScore ghScore;  //you have to link the object here
    float score;
    List<float> ghScoreList;  // whn  u retrive saved score

    public TextMeshProUGUI finalscoreText;
    public float finalscore = 0f; 
    [Header("Component")]
    [Header("Timer Settings")]

    public TextMeshProUGUI rank1Text;
    public float rank1 = 0f; 
    public TextMeshProUGUI rank2Text;
    public float rank2 = 0f; 
    public TextMeshProUGUI rank3Text;
    public float rank3 = 0f; 
    public TextMeshProUGUI rank4Text;
    public float rank4 = 0f; 
    public TextMeshProUGUI rank5Text;
    public float rank5 = 0f; 

    void Start()
    {
        finalscore = PlayerPrefs.GetFloat("finalscore", 0);
        //condition for posting score
        ghScore.SaveHighScore(finalscore);
 
        rank1= finalscore;
        rank2= ghScore.GetHighScore(2);
        rank3= ghScore.GetHighScore(3);
        rank4= ghScore.GetHighScore(4);
        rank5= ghScore.GetHighScore(5);

        rank1Text.text = rank1.ToString("0.00");
        rank2Text.text = rank2.ToString("0.00");
        rank3Text.text = rank3.ToString("0.00");
        rank4Text.text = rank4.ToString("0.00");
        rank5Text.text = rank5.ToString("0.00");
    }
 
}
