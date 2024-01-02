using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class BossInstaller : MonoBehaviour
    {
        [SerializeField] private Boss _boss;
        [SerializeField] private BossMediator _bossMediator;

        [Header("Boss Life")]
        [SerializeField] private float _life;

        [Header("Boss Grow Up")]
        [SerializeField] private float _scale;
        [SerializeField] private float _growUpCountDown;

        [Header("Boss Change Sprite")]
        [SerializeField] private List<Sprite> _sprites;
        [SerializeField] private List<Color> _colors;

        private void Awake()
        {
            BossGrowUp bossGrowUp = new BossGrowUp(_scale, _growUpCountDown, _bossMediator);
            BossSpriteRendererChanger bossSpriteRendererChanger = new BossSpriteRendererChanger(_sprites, _colors, GetComponent<SpriteRenderer>());

            BossLife bossLife = new BossLife(_life);

            _bossMediator.Configure(bossGrowUp, bossSpriteRendererChanger);
            _boss.Configure(bossLife);
        }
    }
}