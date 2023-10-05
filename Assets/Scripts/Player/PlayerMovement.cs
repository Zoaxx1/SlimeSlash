using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumForce = 15f;
    [SerializeField] private float gravityScaleInJump = 3f;
    [SerializeField] private float gravityScaleInFall = 5f;
    private bool seeToRigth = true;

    private void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Movement(rb);
        Jump(rb);
    }

    private void Movement (UnityEngine.Rigidbody2D rb)
    {
        float XMove = Input.GetAxis("Horizontal");
        if(XMove < 0 && seeToRigth)
        {
            Rotate();
        } else if (XMove > 0 && !seeToRigth)
        {
            Rotate();
        }
        rb.velocity = new Vector2( XMove * speed, rb.velocity.y);
    }

    private void Jump (UnityEngine.Rigidbody2D rb)
    {
        if (Input.GetKeyDown("up") && Grounded.isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumForce);
            rb.gravityScale = gravityScaleInJump;
        }
        if(rb.velocity.y < 0) {
            rb.gravityScale = gravityScaleInFall;
        }
    }

    private void Rotate()
    {
        seeToRigth = !seeToRigth;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
    }
}
