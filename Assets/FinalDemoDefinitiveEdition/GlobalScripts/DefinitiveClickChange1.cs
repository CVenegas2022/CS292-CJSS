using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DefinitiveClickChange1 : MonoBehaviour
{
    // private GameObject AudioManager;
    // private AudioSource backmusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickMainMenu() {
        // Debug.Log("Changing to the titleScreen(2)");
        SceneManager.LoadScene("DefinitiveTitleScreen");
        /*GameObject obj;
        obj = GameObject.Find("AudioManager2");
        obj.GetComponent<MainMenuScript>().BGM1Button();    
    */}

    public void OnClickRestart() {
        // Debug.Log("Changing to the restartScreen");
        SceneManager.LoadScene("DefinitiveBaseGame");
        /*
        GameObject obj;
        obj = GameObject.Find("AudioManager2");
        obj.GetComponent<MainMenuScript>().BGM1Button();
    */
    }


}
