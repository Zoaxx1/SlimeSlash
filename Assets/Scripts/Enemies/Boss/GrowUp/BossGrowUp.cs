using Assets.Scripts.Enemies.Boss;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGrowUp
{
    private BossMediator _bossMediator;

    private float _scale = 10;
    private float _growUpCountDown = 5;

    public BossGrowUp(
        float scale,
        float growUpCountDown,
        BossMediator bossMediator)
    {
        _scale = scale;
        _growUpCountDown = growUpCountDown;
        _bossMediator = bossMediator;
    }

    public float GrowUpCountDown
    {
        get { return _growUpCountDown; }
    }

    public void GrowUpBoss(Transform transform)
    {
        _growUpCountDown--;
        Vector2 scale = transform.localScale;
        scale.x += _scale;
        transform.localScale = scale;
        if(_growUpCountDown <= 0)
        {
            _bossMediator.GrowUpCountIsEqualToZero();
        }
    }
}
