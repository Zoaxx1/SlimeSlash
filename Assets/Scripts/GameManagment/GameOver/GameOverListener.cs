using Assets.Scripts.Enemies.Boss;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameManagment
{
    public class GameOverListener : MonoBehaviour
    {
        [SerializeField] private Boss _boss;
        [SerializeField] private BossMediator _bossMediator;
        [SerializeField] private PlayerLife _playerLife;
        [SerializeField] private GameOverEvent _gameOverEvent;

        void Update()
        {
            if(_playerLife.Life == 0 || _bossMediator.BossGrowUpToLimit)
            {
                _gameOverEvent.GameIsOver(false);
            }
            else if(_boss.BossLifeIsZero)
            {
                _gameOverEvent.GameIsOver(true);
            }
        }
    }
}