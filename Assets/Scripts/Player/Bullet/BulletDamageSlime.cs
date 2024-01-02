using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public class BulletDamageSlime : IBulletDamage
    {
        private SlimeLife _slimeLife;
        public BulletDamageSlime(SlimeLife slimeLife)
        {
            _slimeLife = slimeLife;
        }

        public void MakeDamage(float damage)
        {
            _slimeLife.TakeDamage(damage);
        }
    }
}