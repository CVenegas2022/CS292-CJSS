using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewJump : MonoBehaviour
{
    public float jumpSpeed = 40f;
    public float maxHeight = 5f;
    public float jumpGrav = 0f;
    public float fallGrav = 5f;
    public Rigidbody2D myRB;
    public Collider2D ground;
    public AudioSource jumpSource;
    public AudioSource runSource;
    public AudioSource hitSource;
    private bool isGrounded;
    private bool canTravel;
    private bool keyHeld;
    private bool hitCeiling;
    private bool triggerFall;
    private bool fallTriggered;
    //public bool testBoolean = false; //test for raycast
    //private RaycastHit2D[] list;
    private Vector3 jumpPos;

    // Used these two sources to get animation to work correctly https://www.youtube.com/watch?v=07GUMwiOPBE and 
    // https://guilbomadev.medium.com/unity-trigger-an-animation-through-code-5242aef3a578

    // Only works if the player can actually touch the max height
     
    // Start is called before the first frame update
    void Start()
    {
        //initialize isGrounded to false
        isGrounded=false;

        //initialize canTravel to false
        canTravel=false;

        //initialize keyHeld to true
        keyHeld=true;

        hitCeiling=false;
        triggerFall=false;

        //list=new RaycastHit2D[];
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        //used this forum to figure out how to reference an object's BoxCollider2D: https://forum.unity.com/threads/check-if-two-colliders-are-touching.693817/
        
        //test code for Raycast
        /*
        if(gameObject.GetComponent<BoxCollider2D>().Raycast(Vector2.down, new RaycastHit2D[5], 2.7f)>0)
        {
            Debug.Log("Grounded");
        }
        else
        {
            Debug.Log("Not grounded");
        }*/

        //if touching the ground
        //if(gameObject.GetComponent<BoxCollider2D>().IsTouching(ground))
        if(gameObject.GetComponent<BoxCollider2D>().Raycast(Vector2.down, new RaycastHit2D[5], 1.2f)>0)
        {
            //set jumpPos to current position with max height added to the y value
            jumpPos = new Vector3(transform.position.x, transform.position.y+maxHeight, transform.position.z);
            
            //play run sound
            if(!runSource.isPlaying)
            {
                runSource.Play();
            }

            //if not marked as on the ground
            if(!isGrounded)
            {
                //play the run animation
                GetComponent<Animator>().SetTrigger("endJump");
            }
            //mark as on the ground
            isGrounded=true;

            
            hitCeiling=false;
            triggerFall=false;
            fallTriggered=false;

            //if key is marked as held and up is not being pressed
            if(keyHeld && !Input.GetKey("up"))
            {
                //mark as key not being held
                keyHeld=false;
            }
            
            //allow player to jump
            canTravel=true;

            //set gravity to desired jump gravity
            GetComponent<Rigidbody2D>().gravityScale=jumpGrav;
        }
        //if not on the ground
        else
        {
            //mark as not on the ground
            isGrounded=false;

            //if at or over desired max height
            if(transform.position.y>=jumpPos.y)
            {
                //prevent travel
                canTravel=false;
                if(!triggerFall && !fallTriggered)
                {
                    triggerFall=true;
                }
                hitCeiling=true;
            }
        }

        //if the player is able to move upwards
        if(canTravel)
        {
            //if pressing up button
            if(Input.GetKey("up"))
            {
                //if on the ground and the key isn't held from last jump
                if(isGrounded && !keyHeld)
                {
                    //mark key as being held down
                    keyHeld=true;
                    
                    //stop run sound
                    runSource.Pause();

                    //play jump sound
                    jumpSource.Play();
                    //play jump animation
                    GetComponent<Animator>().SetTrigger("startJump");

                    //move towards jumpPos
                    //transform.position = Vector3.MoveTowards(transform.position, jumpPos, jumpSpeed * Time.deltaTime);
                    myRB.velocity=new Vector2(0, jumpSpeed);
                }
                //if the player is not on the ground
                else if(!isGrounded)
                {
                    //move towards jumpPos
                    //transform.position = Vector3.MoveTowards(transform.position, jumpPos, jumpSpeed * Time.deltaTime);
                    myRB.velocity=new Vector2(0, jumpSpeed);
                }
            }
            //if not pressing up button
            else
            {
                if(jumpSource.isPlaying)
                {
                    jumpSource.Stop();
                }
                //mark key as not being held
                keyHeld=false;
                //prevent the player from being able to move up
                canTravel=false;

                myRB.velocity = new Vector2(0, 0);
            }

        }
        //if the player can no longer move up
        else
        {
            //set to higher gravity
            GetComponent<Rigidbody2D>().gravityScale=fallGrav;
            if(hitCeiling)
            {
                if(triggerFall)
                {
                    myRB.velocity = new Vector2(0, 0);
                    triggerFall=false;
                    fallTriggered=true;
                }
                hitCeiling=false;
            }
            if(!Input.GetKey("up"))
            {
                keyHeld=false;
            }
        }
        
    }
}
