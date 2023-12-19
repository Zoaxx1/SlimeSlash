using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class CollisionDamagePlayer : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerLife>().TakeDamage(1f);
            }
        }
    }
}