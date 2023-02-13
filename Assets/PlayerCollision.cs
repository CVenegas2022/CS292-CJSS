using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public int c = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "mediumSpike(Clone)" || collision.gameObject.name == "hardFires(Clone)" || collision.gameObject.name == "hardSpear(Clone)" || collision.gameObject.name == "hardSpike(Clone)")
        {

            hbHealthManager.totalCherries --;
            if(hbHealthManager.totalCherries <= 0)
            {
                //gameover
            }
        }
    }

}
