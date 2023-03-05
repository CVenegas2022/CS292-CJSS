using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecordsManager : MonoBehaviour
{
    public TextMeshProUGUI RankingCurrent;
    RankingCurrent.text = string.Format("{0:N3}cm", PlayerPrefs.GetFloat("finalscore"));

    for (int i = 0; i < 5; i++) {
        rankScore[i] = PlayerPrefs.GetFloat(i + "highscore");
        RankScoreText[i].text = string.Format("{0:N3}cm", rankScore[i]);
        
        if (RankingCurrent.text == RankScoreText[i].text) {
            Color Rank = new Color(255, 255, 0);
            RankText[i].color = Rank;
            RankScoreText[i].color = Rank;
        }
    }
}
