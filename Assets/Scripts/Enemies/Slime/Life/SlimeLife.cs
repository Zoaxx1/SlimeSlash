using Assets.Scripts;
using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeLife : MonoBehaviour
{
    private float _life = 20;
    private float _damage;

    private ISlimeMediator _slimeMediator;

    public void Configure(ISlimeMediator slimeMediator, float life)
    {
        _slimeMediator = slimeMediator;
        _life = life;
    }

    public float Life {
        get { return _life; }
    }

    public void TakeDamage(float damage)
    {
        _damage = damage;
        _slimeMediator.SlimeTakingDamage();
    }

    public void SlimeLessHisLife()
    {
        _life -= _damage;
    }
}
