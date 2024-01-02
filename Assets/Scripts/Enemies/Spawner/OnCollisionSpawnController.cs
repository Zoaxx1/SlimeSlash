using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public class OnCollisionSpawnController : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                _spawner.SpawnNow();
            }
        }
    }
}