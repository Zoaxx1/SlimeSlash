using Assets.Scripts.Player.Bullet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletOnCollision : MonoBehaviour
{
    private IBulletDamage _bulletDamage;
    private Bullet _bullet;

    private void Awake()
    {
        _bullet = GetComponent<Bullet>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        BulletCollisionWith(collision.tag, collision);
    }

    public void BulletCollisionWith(string tag, Collider2D collision)
    {
        if (tag == "Boss")
        {
            _bulletDamage = new BulletDamageBoss(collision.GetComponent<BossLife>());
        }
        else if (tag == "Enemy" || tag == "PowerUp")
        {
            _bulletDamage = new BulletDamageSlime(collision.GetComponent<SlimeLife>());
        }
        else
        {
            _bullet.DestroyThis();
            return;
        }

        _bullet.MakeCollision(_bulletDamage);
    }
}
