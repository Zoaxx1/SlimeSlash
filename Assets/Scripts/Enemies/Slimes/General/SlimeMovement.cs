using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool goToRight;
    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        if (!goToRight)
        {
            rb.MovePosition(transform.position + (transform.right * -1) * speed * Time.fixedDeltaTime);
        } else
        {
            rb.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
        }
    }
}
