using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class BossMediator : MonoBehaviour, IBossMediator
    {
        private BossGrowUp _bossGrowUp;
        private BossSpriteRendererChanger _bossSpriteRendererChanger;

        private bool _bossGrowUpToLimit = false;

        public bool BossGrowUpToLimit {
            get { return _bossGrowUpToLimit; } 
        }

        public void Configure(BossGrowUp bossGrowUp, BossSpriteRendererChanger bossSpriteRendererChanger)
        {
            _bossGrowUp = bossGrowUp;
            _bossSpriteRendererChanger = bossSpriteRendererChanger;
        }

        public void PowerUpCollisionWithBoss()
        {
            _bossGrowUp.GrowUpBoss(transform);
            _bossSpriteRendererChanger.UpdateSpriteRenderer();
        }

        public void GrowUpCountIsEqualToZero()
        {
            _bossGrowUpToLimit = true;
        }
    }
}