using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class SpriteChanger : ISpriteRendererChanger
    {

        private List<Sprite> _sprites = new List<Sprite>();

        public SpriteChanger(List<Sprite> sprites)
        {
            _sprites = sprites;
        }

        public void ChangeSpriteRender(SpriteRenderer spriteRenderer)
        {
            if (_sprites.Count > 0)
            {
                spriteRenderer.sprite = _sprites[0];
                _sprites.RemoveAt(0);
            }
        }
    }
}