using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using System.Collections;
public class PlayerCollision : MonoBehaviour
{
    public float invincTime = 3;
    public int c = 0;
    public SpriteRenderer playerSprite;
    //private float iFrames;
    private float timeTracker;
    private bool isInvincible;
    private Color baseColor;
    private Color phantom;

    void Start()
    {
        //iFrames=60*seconds;
        timeTracker=0f;
        isInvincible=false;
        baseColor=playerSprite.color;
        phantom=baseColor;
        phantom.a=0.7f;
    }

    void Update()
    {
        if(isInvincible)
        {
            if(timeTracker<=invincTime)
            {
                timeTracker += Time.deltaTime;
            }
            else
            {
                isInvincible=false;
                timeTracker=0f;
                playerSprite.color=baseColor;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((collision.gameObject.name == "mediumSpike(Clone)" || collision.gameObject.name == "hardFires(Clone)" || collision.gameObject.name == "hardSpear(Clone)" || collision.gameObject.name == "hardSpike(Clone)") && !isInvincible)
        {

            hbHealthManager.totalCherries --;
            isInvincible=true;
            playerSprite.color=phantom;

            if(hbHealthManager.totalCherries <= 0)
            {
                //gameover
                SceneManager.LoadScene("gameOverScreenDemo2-1");
            }
        }
    }

}
