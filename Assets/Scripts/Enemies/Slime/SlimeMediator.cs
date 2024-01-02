using Assets.Scripts.Enemies.DamagePlayer;
using Assets.Scripts.Enemies.Slimes.Destroyer;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes
{
    public class SlimeMediator : MonoBehaviour, ISlimeMediator
    {
        private SlimeLife _slimeLife;
        private IDamagePlayer _damagePlayer;

        public void Configure(
            float life,
            SlimeLife slimeLife,
            IDamagePlayer damagePlayer
            )
        {
            _slimeLife = slimeLife;
            _damagePlayer = damagePlayer;

            _slimeLife.Configure(this, life);
            _damagePlayer.Configure(this);
        }

        public void SlimeMakeCollision()
        {
            TryDestroy();
        }
        public void SlimeTakingDamage()
        {
            if(_slimeLife.Life <= 1)
            {
                TryDestroy();
                return;
            }
            _slimeLife.SlimeLessHisLife();
        }
        public void SlimeLifeIsZero()
        {
            TryDestroy();
        }
        private void TryDestroy()
        {
            Destroy(gameObject);
        }

        public void SlimeContactWithThePlayer()
        {
            _damagePlayer.MakeDamageToPlayer();
        }
    }
}