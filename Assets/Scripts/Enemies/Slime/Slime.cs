using Assets.Scripts.Enemies.DamagePlayer;
using Assets.Scripts.Enemies.Slimes.General;
using Assets.Scripts.Enemies.Spawner;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes
{
    public class Slime : MonoBehaviour
    {
        [SerializeField] private SlimeId _id;
        private ISlimeMover _slimeMover;
        private Rigidbody2D _rb;

        public string Id => _id.Value;

        public void Configure(ISlimeMover slimeMover)
        {
            _slimeMover = slimeMover;
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            SlimeMove();
        }

        private void SlimeMove()
        {
            transform.position = _slimeMover.GetDirection(transform);
        }
    }
}