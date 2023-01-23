using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideFunction : MonoBehaviour
{
    public BoxCollider2D targetCollider;
    public BoxCollider2D ground;
    public Transform targetTransform;
    public float newHeight;
    private float baseHeight;
    private Vector2 baseSize;
    private Vector2 newSize;
    private Vector3 currLocation;
    private Vector3 newLocation;
    private bool isChanged;
    // Start is called before the first frame update
    void Start()
    {
        //baseHeight=targetCollider.size.y;
        baseSize=targetCollider.size;
        newSize=new Vector2(targetCollider.size.x, newHeight);
        isChanged=false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(targetCollider.IsTouching(ground) && Input.GetKey("down"))
        {
            if(!isChanged)
            {
                currLocation=targetTransform.position;
                newLocation=currLocation;
            
                if(newHeight>baseHeight)
                {
                    newLocation.y+=(newHeight/2);
                }
                else if(newHeight<baseHeight)
                {
                    newLocation.y-=newHeight;
                }
                targetTransform.position=newLocation;
                targetCollider.size=newSize;
                isChanged=true;
                //play animation
            }
        }
        else
        {
            if(isChanged)
            {
                transform.position=currLocation;
                targetCollider.size=baseSize;
                //stop animation
            }
        }
    }
}
