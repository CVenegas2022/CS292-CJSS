using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScreen : MonoBehaviour
    
    public Text pointsText;

    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";  
    }
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
