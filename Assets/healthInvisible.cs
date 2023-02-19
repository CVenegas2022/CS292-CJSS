using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthInvisible : MonoBehaviour
{
    public SpriteRenderer healthSprite;
    private Color invisible;
    // Start is called before the first frame update
    void Start()
    {
        invisible = healthSprite.color;
        invisible.a = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "coolerPlayer Variant"){
            healthSprite.color = invisible;
        }
    }
}
