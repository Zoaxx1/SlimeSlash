using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class Boss : MonoBehaviour
    {
        private BossLife _bossLife;

        private bool _bossLifeIsZero = false;

        public bool BossLifeIsZero
        {
            get { return _bossLifeIsZero; }
        }

        public void Configure(BossLife bossLife)
        {
            _bossLife = bossLife;
        }

        void Update()
        {
            if(_bossLife.Life <= 0)
            {
                _bossLifeIsZero = true;
                Destroy(gameObject);
            }
        }
    }
}