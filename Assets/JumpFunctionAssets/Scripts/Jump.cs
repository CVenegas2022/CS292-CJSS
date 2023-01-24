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
    private bool needsAnimationSwap;
    private bool keyHeld;
    private Vector3 jumpPos;
    //public Vector2 force=new Vector2(0,10,0);

    // Only works if the player can actually touch the max height.  Gravity scale 0 for jumpGrav gives desired effect. 
    // Start is called before the first frame update
    void Start()
    {
        isGrounded=false;
        canTravel=false;
        needsAnimationSwap=true;
        keyHeld=true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        //used this forum to figure out how to reference an object's BoxCollider2D: https://forum.unity.com/threads/check-if-two-colliders-are-touching.693817/
        if(gameObject.GetComponent<BoxCollider2D>().IsTouching(ground))
        {
            jumpPos = new Vector3(transform.position.x, transform.position.y+maxHeight, transform.position.z);
            isGrounded=true;
            if(keyHeld && !Input.GetKey("up"))
            {
                keyHeld=false;
            }
            canTravel=true;
            GetComponent<Rigidbody2D>().gravityScale=jumpGrav;
            if(needsAnimationSwap)
            {
                GetComponent<Animator>().Play("Base Layer.Run");
                needsAnimationSwap=false;
            }
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
                if(isGrounded && !keyHeld)
                {
                    keyHeld=true;
                    GetComponent<Animator>().Play("Base Layer.Jump");
                    needsAnimationSwap=true;
                    transform.position = Vector3.MoveTowards(transform.position, jumpPos, jumpSpeed * Time.deltaTime);
                }
                else if(!isGrounded)
                {
                    transform.position = Vector3.MoveTowards(transform.position, jumpPos, jumpSpeed * Time.deltaTime);
                }
                //GetComponent<Rigidbody2D>().AddForce(transform.up * jumpSpeed, ForceMode2D.Impulse);
            }
            //release up button
            else
            {
                keyHeld=false;
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
