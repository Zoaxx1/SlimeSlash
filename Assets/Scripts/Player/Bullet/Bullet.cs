using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boss"))
        {
            collision.GetComponent<BossLife>().TakeDamage(damage);
        }
        if (collision.CompareTag("Enemy") || collision.CompareTag("PowerUp"))
        {
            collision.GetComponent<SlimeLife>().TakeDamage();
        }
        Destroy(gameObject);
    }
}
