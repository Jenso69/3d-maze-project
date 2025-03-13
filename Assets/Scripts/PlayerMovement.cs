using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //we put information at the start of a class
    
    public float speed = 4.5f;
    public float jumpForce = 5;
    public string hero = "Jenso";
    
    // Start is called before the first frame update


    //xyz coordination
    public Vector3 direction;
    public Rigidbody playerRB;


    void Start()
    {
        Debug.Log("My name is " + hero);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(direction * Time.deltaTime * speed);
        Vector3 velocity = direction * speed;
        velocity.y = playerRB.linearVelocity.y;



        playerRB.linearVelocity = velocity;




    }


    private void OnMove(InputValue value)
    {

        //ask the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(
            inputValue.x,
            0,
            inputValue.y
        );
    }



    private void OnJump (InputValue value)
    {

        //physics.Raycast will cast a line that can hit colliders if it finds a collider it returns true, if it doesnt, it returns false.

        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);

        if (isGrounded)
        
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }


    }

}    