using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditSceneScript : MonoBehaviour
{
    public string mainMenuScene;
    public void loadMainMenu()
        {
            SceneManager.LoadScene(mainMenuScene);
        }
}
