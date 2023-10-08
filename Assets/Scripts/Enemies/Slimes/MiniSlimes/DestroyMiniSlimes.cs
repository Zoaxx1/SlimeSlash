using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMiniSlimes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerLife>().TakeDamage();
        }
        Destroy(gameObject);
    }
}
