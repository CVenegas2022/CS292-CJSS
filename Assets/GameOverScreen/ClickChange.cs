using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;
using UnityEngine.SceneManagement;

public class ClickChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMainMenu() 
    {
        SceneManager.LoadScene("titleScreen(2)");
        Debug.Log("Game Scene transition1");
    }

    public void onClickRestart() 
    {
        SceneManager.LoadScene("DemoScence1");
        Debug.Log("Game Scene transition2");
    }
}
