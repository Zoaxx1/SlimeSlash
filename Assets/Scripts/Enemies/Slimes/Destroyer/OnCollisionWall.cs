using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes.Destroyer
{
    public class OnCollisionWall : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                collision.gameObject.GetComponent<PowerSlimeSpawn>().SpawnPowerSlime();
                Destroy(gameObject);
            }
        }
    }
}