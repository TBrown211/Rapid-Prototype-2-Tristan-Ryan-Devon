using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    //Variables for player inputs
    public float playerSpeed = 1.0f;  //Assigning a speed variable for the player
    public float jumpForce = 2.0f;

    //Variables for the charge attack mechanic
    private SpriteRenderer knightSP;
    public float chargeTime = 0.0f;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(chargeTime);
        rb2D = GetComponent<Rigidbody2D>();
        knightSP = rb2D.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKey(KeyCode.R))
        {
            chargeTime += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.R) && chargeTime > 2)
        {
            rb2D.velocity = Vector2.right * playerSpeed;
            chargeTime = 0;

        }
        if(Input.GetKeyUp(KeyCode.R) && chargeTime < 2)
        {
            chargeTime = 0;
        }
    }

    void PlayerMovement()
    {
        //Assiging booleans to the key inputs
        bool movingLeft = Input.GetKey(KeyCode.A); //Pressing A key will move the player left
        bool movingRight = Input.GetKey(KeyCode.D); //Pressing the D key will move the player right
        bool hitJump = Input.GetKey(KeyCode.Space); //Pressing the Space key will force player to jump

        Vector3 input = new Vector3(); //This Vector3 variable is meant for recieving input from player

        if (movingLeft)
        {
            input.x += -playerSpeed * Time.deltaTime;
        }
        if (movingRight)
        {
            input.x += playerSpeed * Time.deltaTime;
        }
        if (hitJump)
        {
            input.y += jumpForce * Time.deltaTime;
        }

        transform.position += input;
    }
}
