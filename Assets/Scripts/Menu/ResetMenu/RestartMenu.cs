using System.Collections;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.GameManagment
{
    public class RestartMenu : MonoBehaviour
    {
        [SerializeField] private GameObject _restartMenu;
        [SerializeField] private TextMeshProUGUI _restartMenuTitle;

        private IRestartMenuProperty _looseRestartMenu;
        private IRestartMenuProperty _winRestartMenu;

        void Awake()
        {
            _restartMenu.SetActive(false);
            _looseRestartMenu = new LooseRestartMenu();
            _winRestartMenu = new WinRestartMenu();
        }

        private void SetRestartMenuTitle(IRestartMenuProperty restartMenu)
        {
            Color color = restartMenu.GetColor();
            string text = restartMenu.GetText();
            _restartMenuTitle.text = text;
            _restartMenuTitle.color = color;
            _restartMenu.SetActive(true);
        }

        public void ShowWinRestartMenu()
        {
            SetRestartMenuTitle(_winRestartMenu);
        }

        public void ShowLooseRestartMenu()
        {
            SetRestartMenuTitle(_looseRestartMenu);
        }
    }
}