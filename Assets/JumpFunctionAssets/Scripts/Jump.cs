using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed = 30f;
    public float maxHeight = 5f;
    public float jumpGrav = 0f;
    public float fallGrav = 7f;
    public BoxCollider2D ground;
    private bool isGrounded;
    private bool canTravel;
    private Vector3 jumpPos;

    // Only works if the player can actually touch the max height.  Gravity scale 0 for jumpGrav gives desired effect. 
    // Start is called before the first frame update
    void Start()
    {
        jumpPos = new Vector3(transform.position.x, transform.position.y+maxHeight, transform.position.z);
        isGrounded=false;
        canTravel=false;
    }

    // Update is called once per frame
    void Update()
    {
        //used this forum to figure out how to reference an object's BoxCollider2D: https://forum.unity.com/threads/check-if-two-colliders-are-touching.693817/
        if(gameObject.GetComponent<BoxCollider2D>().IsTouching(ground))
        {
            isGrounded=true;
            canTravel=true;
            GetComponent<Rigidbody2D>().gravityScale=jumpGrav;
        }
        else
        {
            isGrounded=false;
            if(transform.position.y>=jumpPos.y)
            {
                canTravel=false;
            }
        }

        if(canTravel)
        {
            //pressing up button
            if(Input.GetKey("up"))
            {
                
                transform.position = Vector3.MoveTowards(transform.position, jumpPos, jumpSpeed * Time.deltaTime);
            }
            //release up button
            else
            {
                canTravel=false;
            }

        }
        else
        {
            //set to higher gravity
            GetComponent<Rigidbody2D>().gravityScale=fallGrav;
        }
        
    }

    public bool getIsGrounded()
    {
        return isGrounded;
    }
}
