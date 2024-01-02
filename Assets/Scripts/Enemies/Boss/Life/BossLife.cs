using Assets.Scripts;
using UnityEngine;

public class BossLife : IDamaged
{
    private float _life = 100;

    public BossLife(float life)
    {
        _life = life;
    }

    public float Life
    {
        get { return _life; }
    }

    public void TakeDamage(float damage)
    {
        _life -= damage;
    }
}
