using System.Collections;
using UnityEngine;

namespace Assets.Scripts.GameManagment
{
    public class WinRestartMenu : IRestartMenuProperty
    {
        private string _winTitle = "You Win";
        private Color _winTextColor = Color.green;

        public Color GetColor()
        {
            return _winTextColor;
        }

        public string GetText()
        {
            return _winTitle;
        }
    }
}