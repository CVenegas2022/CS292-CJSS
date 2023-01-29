using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    [Header("Component")]
    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;
    private bool shouldUpdate;

    // Start is called before the first frame update
    void Start()
    {
        shouldUpdate=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldUpdate)
        {
            currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
            timerText.text = currentTime.ToString();
        }
    }

    //Changes shouldUpdate to true if false
    public void toggleShouldUpdateOff()
    {
        if(shouldUpdate)
        {
            shouldUpdate=false;
        }
    }
}
