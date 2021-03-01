using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour{

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float HorizMove = 0f;
    bool jump  = false;
    void Update()
    {
       HorizMove = Input.GetAxisRaw("Horizontal") * runSpeed;

       if (Input.GetButtonDown("Jump"))
       {
           jump = true;
       }
    }

    void FixedUpdate()
    {
        controller.Move(HorizMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
