using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boss"))
        {
            collision.GetComponent<BossLife>().TakeDamage(damage);
        }
        if (collision.CompareTag("Enemy") || collision.CompareTag("PowerUp"))
        {
            collision.GetComponent<SlimeLife>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
