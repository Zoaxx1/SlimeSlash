using Assets.Scripts.Enemies.Slimes;
using Assets.Scripts.Enemies.Slimes.Destroyer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SlimeMediator))]
public class OnCollisionBoss : MonoBehaviour, IOnCollision
{
    private SlimeMediator _slimeMediator;

    private void Awake()
    {
        _slimeMediator = GetComponent<SlimeMediator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            SlimeCollision();
        }
    }
    public void SlimeCollision()
    {
        _slimeMediator.SlimeMakeCollision();
    }
}
