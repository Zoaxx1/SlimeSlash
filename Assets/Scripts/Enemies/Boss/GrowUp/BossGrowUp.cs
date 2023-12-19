using Assets.Scripts.Enemies.Boss;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGrowUp : MonoBehaviour
{
    [SerializeField] private float _scale;

    [SerializeField] private List<Sprite> _sprites;
    [SerializeField] private List<Color> _colors;

    private SpriteRendererChanger _spriteRendererChanger;

    private float _growUpCountDown = 5;

    public float GrowUpCountDown
    {
        get { return _growUpCountDown; }
    }

    void Awake()
    {
        _spriteRendererChanger = new SpriteRendererChanger(_sprites, _colors, GetComponent<SpriteRenderer>());
    }

    public void GrowUp()
    {
        _growUpCountDown--;
        _spriteRendererChanger.UpdateSpriteRenderer();
        TransformLocalScaleScaled();
    }

    private void TransformLocalScaleScaled()
    {
        Vector2 scale = transform.localScale;
        scale.x += 10;
        transform.localScale = scale;
    }
}
