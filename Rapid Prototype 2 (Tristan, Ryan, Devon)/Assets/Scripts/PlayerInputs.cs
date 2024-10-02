using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public float playerSpeed = 1.0f;  //Assigning a speed variable for the player

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        //Assiging booleans to the key inputs
        bool movingLeft = Input.GetKey(KeyCode.A); //Pressing A key will move the player left
        bool movingRight = Input.GetKey(KeyCode.D); //Pressing the D key will move the player right

        Vector3 input = new Vector3(); //This Vector3 variable is meant for recieving input from player

        if (movingLeft)
        {
            input.x += -playerSpeed * Time.deltaTime;
        }
        if(movingRight)
        {
            input.x += playerSpeed * Time.deltaTime;
        }

        transform.position += input;
    }
}
