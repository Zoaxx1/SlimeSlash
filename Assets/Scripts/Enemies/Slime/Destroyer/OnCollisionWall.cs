using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes.Destroyer
{
    [RequireComponent(typeof(SlimeMediator))]
    public class OnCollisionWall : MonoBehaviour, IOnCollision
    {
        private SlimeMediator _slimeMediator;

        private void Awake()
        {
            _slimeMediator = GetComponent<SlimeMediator>();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Wall"))
            {
                SlimeCollision();
            }
        }

        public void SlimeCollision()
        {
            _slimeMediator.SlimeMakeCollision();
        }
    }
}