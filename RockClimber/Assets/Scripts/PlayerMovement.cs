using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce;

    //public Rigidbody hips;
    public bool isGrounded;

    private Vector2 startTouchPosition, endTouchPosition;
    private Rigidbody rb;
    private bool jumpAllowed = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
       // hips = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        SwipeCheck();
    }

    private void FixedUpdate()
    {
        /* if (Input.GetAxis("Jump") > 0)
         {
             if (isGrounded)
             {
                 hips.AddForce(new Vector3(0, jumpForce, 0));
                 isGrounded = false;
             }
         }*/

        JumpIfAllowed();
    }

    private void JumpIfAllowed()
    {
        if(jumpAllowed)
        {
            rb.AddForce(Vector2.up * jumpForce);
            jumpAllowed = false;
        }
    }

    private void SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
            endTouchPosition = Input.GetTouch(0).position;

        if (endTouchPosition.y > startTouchPosition.y && rb.velocity.y == 0)
            jumpAllowed = true;
    }
}
