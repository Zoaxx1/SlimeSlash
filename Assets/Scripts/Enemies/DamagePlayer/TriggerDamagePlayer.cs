using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class TriggerDamagePlayer : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                collision.gameObject.GetComponent<PlayerLife>().TakeDamage(1f);
            }
        }
    }
}