using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller;
    public float moveSpeed = 5f;
    public Animator animator; 
    

    float horizontalMovement = 0f;
    bool jumping = false;
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * moveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMovement));

        if(Input.GetButtonDown("Jump"))
        {
            jumping = true;
            animator.SetBool("Jump", true);
        }
    }

    public void OnLanding()
    {
        animator.SetBool("Jump", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMovement * Time.fixedDeltaTime, false, jumping);
        jumping = false;
    }
}
