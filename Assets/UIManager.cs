using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject imageRestart;

    public void Restart()
    {
        SceneManager.LoadScene("DemoScene1");
    }
}
