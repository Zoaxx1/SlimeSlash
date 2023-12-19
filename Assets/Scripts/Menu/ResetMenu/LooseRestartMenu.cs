using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameManagment
{
    public class LooseRestartMenu : IRestartMenuProperty
    {
        private string _looseTitle = "You Lose";
        private Color _looseTextColor = Color.red;

        public Color GetColor()
        {
            return _looseTextColor;
        }

        public string GetText()
        {
            return _looseTitle;
        }
    }
}