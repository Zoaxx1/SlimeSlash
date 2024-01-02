using Assets.Scripts.Enemies.Slimes;
using Assets.Scripts.Enemies.Slimes.Destroyer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SlimeMediator))]
public class OnCollisionAll : MonoBehaviour, IOnCollision
{
    private SlimeMediator _slimeMediator;

    private void Awake()
    {
        _slimeMediator = GetComponent<SlimeMediator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SlimeCollision();
    }

    public void SlimeCollision()
    {
        _slimeMediator.SlimeMakeCollision();
    }
}
