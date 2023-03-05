using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    GameObject AudioManager;
    AudioSource backmusic;
        AudioManager = GameObject.Find("AudioManager");
        backmusic = AudioManager.GetComponent<AudioSource>();
        if(backmusic.isPlaying) return;
        else backmusic.Play();
    }
}
