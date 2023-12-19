using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class StartSpawnerSlime : MonoBehaviour
    {
        [SerializeField] PowerSlimeSpawn _powerSlimeSpawn;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            _powerSlimeSpawn.SpawnPowerSlime();
        }
    }
}