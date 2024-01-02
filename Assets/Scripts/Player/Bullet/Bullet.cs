using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public class Bullet : MonoBehaviour
    {
        private float _damage;
        private IBulletMover _bulletMover;
        private Rigidbody2D _rb;

        public void Configure(
            float damage,
            IBulletMover bulletMover
            )
        {
            _damage = damage;
            _bulletMover = bulletMover;
            _rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            _rb.MovePosition(_bulletMover.GetDirection(transform));
        }

        public void MakeCollision(IBulletDamage bulletDamage)
        {
            bulletDamage.MakeDamage(_damage);
            DestroyThis();
        }

        public void DestroyThis()
        {
            Destroy(gameObject);
        }
    }
}