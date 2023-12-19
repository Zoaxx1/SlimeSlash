using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameManagment
{
    public class GameOverListener : MonoBehaviour
    {
        [SerializeField] private BossLife _bossLife;
        [SerializeField] private PlayerLife _playerLife;
        [SerializeField] private BossGrowUp _bossGrowUp;
        [SerializeField] private GameOverEvent _gameOverEvent;

        void Update()
        {
            if(_playerLife.Life == 0 || _bossGrowUp.GrowUpCountDown == 0)
            {
                Debug.Log(_playerLife.Life);
                Debug.Log("false");
                _gameOverEvent.GameIsOver(false);
            }
            else if(_bossLife.Life == 0)
            {
                Debug.Log(_bossLife.Life);
                Debug.Log("true");
                _gameOverEvent.GameIsOver(true);
            }
        }
    }
}