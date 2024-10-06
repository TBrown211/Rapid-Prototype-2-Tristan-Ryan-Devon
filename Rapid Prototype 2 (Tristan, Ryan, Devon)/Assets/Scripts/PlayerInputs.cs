using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    //Variables for player inputs
    public float playerSpeed = 1.0f;  //Assigning a speed variable for the player
    public float jumpForce = 2.0f; //Assigning force variable for jumping
    public float gravityForce = 1.0f;
    private bool facingRight = true; //Bool variable to determine whether the player is facing left or right    

    //Variables for the charge attack mechanic
    public Sprite[] knightLib; 
    private SpriteRenderer knightSP; //Variable that stores the sprite 
    public float chargeTime = 0.0f; //variable to keep track of charge time
    private Rigidbody2D rb2D;
    private Animator animator;
    public float animationTimer = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(chargeTime);
        rb2D = GetComponent<Rigidbody2D>();       
        animator = GetComponent<Animator>();   
        knightSP = GetComponent<SpriteRenderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        ChargingMechanic();        
    }

    //Function for the main player controller of the game
    void PlayerMovement()
    {
        //Assiging booleans to the key inputs
        bool movingLeft = Input.GetKey(KeyCode.A); //Pressing A key will move the player left
        bool movingRight = Input.GetKey(KeyCode.D); //Pressing the D key will move the player right
        bool hitJump = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W); //Pressing the Space or W key will force player to jump

        Vector3 input = new Vector3(); //This Vector3 variable is meant for recieving input from player

        if (movingLeft)
        {
            facingRight = false;
            knightSP.flipX = true;
            input.x += -playerSpeed * Time.deltaTime;
        }
        if (movingRight)
        {
            facingRight = true;
            knightSP.flipX = false;
            input.x += playerSpeed * Time.deltaTime;
        }
        if (hitJump)
        {
            input.y += jumpForce * Time.deltaTime;
        }

        transform.position += input;
    }

    //Function for the main charging mechanic
    void ChargingMechanic()
    {
        if (Input.GetKey(KeyCode.R))
        {
            chargeTime += Time.deltaTime; //When R is held down, the charge timer increases          

        }
        if (Input.GetKeyUp(KeyCode.R) && chargeTime > 2)
        {
            if (facingRight)
            {
                //When R key is released and the charge time is over 2 seconds
                rb2D.velocity = Vector2.right * playerSpeed; //The player is propelled to the right by velocity times player speed
                chargeTime = 0; //Resets timer after release                
            }
            else if (!facingRight)
            {
                //When R key is released and the charge time is over 2 seconds
                rb2D.velocity = Vector2.left * playerSpeed; //The player is propelled to the right by velocity times player speed
                chargeTime = 0; //Resets timer after release               
            }           


        }
        if (Input.GetKeyUp(KeyCode.R) && chargeTime < 2)
        {
            chargeTime = 0; //This is to make sure that the timer is reset to 0 after key is lifted            
        }
    }
}
