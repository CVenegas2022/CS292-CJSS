using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialNextButton1 : MonoBehaviour
{

    public void OnClickNext1() {
        //Debug.Log("tutorial2");
        SceneManager.LoadScene("tutorial2");
    }

    public void OnClickNext2() {
        //Debug.Log("tutorial3");
        SceneManager.LoadScene("tutorial3");
    }

    public void OnClickCancel() {
        //Debug.Log("titleScreen");
        SceneManager.LoadScene("titleScreenDemo2-1");
    }
}
