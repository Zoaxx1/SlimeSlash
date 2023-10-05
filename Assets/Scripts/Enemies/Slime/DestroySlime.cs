using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlime : MonoBehaviour
{
    [SerializeField] private string tagName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerLife>().TakeDamage();
        }
        if (collision.CompareTag(tagName))
        {
            Destroy(gameObject);
        }
    }
}
