﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    //public float speed = 12f;
    ///public float gravity = -9.81f;
    //public float jumpHeight = 3f;

    //public Transform groundCheck;
    //public float groundDistance = 0.4f;
    //public LayerMask groundMask;

    //Vector3 velocity;
    //bool isGrounded;

    Vector2 input;

    // Update is called once per frame
    void FixedUpdate()
    {
        //isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //if(isGrounded && velocity.y < 0)
        //{
            //velocity.y = -2f;
        //}

        input = new Vector2(Input.GetAxis("RightStickVertical"), Input.GetAxis("RightStickHorizontal"));
        input = Vector2.ClampMagnitude(input, 1);

        transform.position += new Vector3(input.x, 0, input.y) * Time.deltaTime * 5;


        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Vector3 move = transform.right * x + transform.forward * z;

        //controller.Move(move * speed * Time.deltaTime);

        //if(Input.GetButtonDown("Jump") && isGrounded)
        //{
            //velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        //}
        
        //velocity.y += gravity * Time.deltaTime;

        //controller.Move(velocity * Time.deltaTime);
    }
}
