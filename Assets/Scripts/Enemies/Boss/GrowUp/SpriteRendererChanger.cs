using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public class SpriteRendererChanger
    {
        private SpriteRenderer _spriteRenderer;
        private ISpriteRendererChanger _colorChanger;
        private ISpriteRendererChanger _spriteChanger;
        
        private int changeSpriteRendererCounter = 0;

        public SpriteRendererChanger(List<Sprite> sprites, List<Color> colors, SpriteRenderer spriteRenderer)
        {
            _spriteRenderer = spriteRenderer;
            _colorChanger = new ColorChanger(colors);
            _spriteChanger = new SpriteChanger(sprites);
        }

        public void UpdateSpriteRenderer()
        {
            if (ChangeSpriteRendererCounterIsPair())
            {
                ChangeSprite();
            }
            else
            {
                ChangeColor();
            }
        }
        private bool ChangeSpriteRendererCounterIsPair()
        {
            changeSpriteRendererCounter += 1;
            return changeSpriteRendererCounter % 2 == 0;
        }
        private void ChangeSprite()
        {
            _spriteChanger.ChangeSpriteRender(_spriteRenderer);
        }
        private void ChangeColor()
        {
            _colorChanger.ChangeSpriteRender(_spriteRenderer);
        }
    }
}