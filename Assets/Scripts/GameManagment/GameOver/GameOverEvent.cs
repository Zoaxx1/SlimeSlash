using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Assets.Scripts.GameManagment;

public class GameOverEvent : MonoBehaviour
{
    public static GameOverEvent Instance { get; private set; }
    [SerializeField] RestartMenu _restartMenu;

    public void GameIsOver (bool playerWin)
    {
        Time.timeScale = 0;
        if(playerWin)
        {
            _restartMenu.ShowWinRestartMenu();
        }
        else
        {
            _restartMenu.ShowLooseRestartMenu();
        }
    }
}
