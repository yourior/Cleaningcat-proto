using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovementPlugin : MonoBehaviour {

    // blum ada rotation animation

    public float movespeed = 0f;

    public float JumpForce = 0f;

    public bool isGround = false;

    Rigidbody2D r2;

    public LayerMask GroundLayer;

    public Transform GroundCheck1;// add another Child Sprite to be the detector , place on the left down bottom
    public Transform GroundCheck2;// add another Child Sprite to be the detector , place on the right down bottom 

    // Use this for initialization
    void Start()
    {

        r2 = GetComponent<Rigidbody2D>();// add Gravity
    }

    // Update is called once per frame
    void FixedUpdate()//isGrounded?
    {
        isGround = Physics2D.OverlapArea(
           GroundCheck1.position,
           GroundCheck2.position,
           GroundLayer);
    }
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, 0);

        // For Jumping


        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.  
        if (isGround && Input.GetKey(KeyCode.Space))
        {
            r2.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
        r2.AddForce(movement * movespeed);

    }
}
