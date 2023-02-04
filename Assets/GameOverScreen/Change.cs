using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public void OnClickMainMenu() 
    {
        SceneManager.LoadScene("titleScreen(2)");
    }

    public void onClickRestart() 
    {
        SceneManager.LoadScene("DemoScence1");
    }
}
