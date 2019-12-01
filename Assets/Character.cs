using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float speed = 4;

    private Vector3 velocity;

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
       

        Vector3 moveAmount = input * speed * Time.deltaTime;
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            velocity = Vector3.zero;
        }

        velocity += Vector3.down * Time.deltaTime;
        controller.Move(moveAmount + velocity);
    }

    // Called instead of OnCollisionEnter.
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // This one's important...
        // hit.normal
    }
}

