using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hbHealthManager : MonoBehaviour
{
    public int totalCherries = 3;

    public Image[] cherries;
    public Sprite cherry;
    public Sprite bug;

    // Update is called once per frame
    void Update()
    {
        foreach(Image img in cherries)
        {
            img.sprite = bug;
        }
        for(int i = 0; i < totalCherries; i++)
        {
            cherries[i].sprite = cherry;
        }
    }
}
