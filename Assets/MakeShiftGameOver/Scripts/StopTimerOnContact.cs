using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimerOnContact : MonoBehaviour
{
    public timer targetTimer;
    public Collider2D targetCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(gameObject.GetComponent<BoxCollider2D>().IsTouching(targetCollider))
        {
            targetTimer.toggleShouldUpdateOff();
        }
    }
}
