using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public class BulletDamageBoss : IBulletDamage
    {
        private BossLife _bossLife;
        public BulletDamageBoss(BossLife bossLife) {
            _bossLife = bossLife;
        }

        public void MakeDamage(float damage)
        {
            _bossLife.TakeDamage(damage);
        }
    }
}