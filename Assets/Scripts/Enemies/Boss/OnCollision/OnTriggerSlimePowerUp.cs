using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class OnTriggerSlimePowerUp : MonoBehaviour
    {
        private BossMediator _bossMediator;

        private void Awake()
        {
            _bossMediator = GetComponent<BossMediator>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("PowerUp")) _bossMediator.PowerUpCollisionWithBoss();
        }
    }
}