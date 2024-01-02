using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public class BulletInstaller : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float damage;

        private void Awake()
        {
            Bullet bullet = GetComponent<Bullet>();

            IBulletMover bulletMover = GetComponent<BulletMover>();

            bulletMover.Configure(speed);

            bullet.Configure(damage, bulletMover);
        }
    }
}