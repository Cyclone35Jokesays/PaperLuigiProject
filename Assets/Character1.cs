using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1 : MonoBehaviour
{
    CharacterController playerController;
    public float speed = 4f;
    public float jump;
    Animator LuigiAnimator;
    public float gravSpeed = 1f;
    SpriteRenderer luigiRenderer;
    

    private Vector3 velocity;

    public enum State
    {
        Walking,
        Swimming
    }

     void Start()
    {
        playerController = GetComponent<CharacterController>();
        LuigiAnimator = GetComponent<Animator>();
        luigiRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), velocity.y, Input.GetAxis("Vertical"));

      
              

        Vector3 moveAmount = input * speed * Time.deltaTime;
       

        if (playerController.isGrounded)
        {
            velocity = Vector3.zero;

            if (Input.GetButtonDown("Jump"))
            {
                velocity.y = jump;
            }
        }

        velocity.y = velocity.y + (Physics.gravity.y * gravSpeed);
        playerController.Move(moveAmount + velocity * Time.deltaTime);

        Animation();
    }

    // Called instead of OnCollisionEnter.
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        
    }

    private void Animation()
    {
        if (true)
        {

        }
        if (Input.GetKey(KeyCode.A))
        {
            luigiRenderer.flipX = true;
            LuigiAnimator.SetBool("IsWalking", true);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            LuigiAnimator.SetBool("IsWalking", true);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            LuigiAnimator.SetBool("IsWalking", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            luigiRenderer.flipX = false;
            LuigiAnimator.SetBool("IsWalking", true);
        }

        else
        { 
            LuigiAnimator.SetBool("IsWalking", false);
        }
    }
}

