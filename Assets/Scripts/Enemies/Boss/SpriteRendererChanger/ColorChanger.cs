using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class ColorChanger : ISpriteRendererChanger
    {
        private List<Color> _colors = new List<Color>();

        public ColorChanger(List<Color> colors)
        {
            _colors = colors;
        }

        public void ChangeSpriteRender(SpriteRenderer spriteRenderer)
        {
            if(_colors.Count > 0)
            {
                spriteRenderer.color = _colors[0];
                _colors.RemoveAt(0);
            }
        }
    }
}