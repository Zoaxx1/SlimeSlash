using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public interface ISpriteRendererChanger
    {
        void ChangeSpriteRender(SpriteRenderer spriteRenderer);
    }
}