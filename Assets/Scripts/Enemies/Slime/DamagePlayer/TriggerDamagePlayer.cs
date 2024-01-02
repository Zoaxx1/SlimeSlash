﻿using Assets.Scripts.Enemies.DamagePlayer;
using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies
{
    public class TriggerDamagePlayer : MonoBehaviour, IDamagePlayer
    {
        private ISlimeMediator _slimeMediator;
        private PlayerLife _playerLife;

        public void Configure(ISlimeMediator slimeMediator)
        {
            _slimeMediator = slimeMediator;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _playerLife = collision.gameObject.GetComponent<PlayerLife>();
                _slimeMediator.SlimeContactWithThePlayer();
            }
        }

        public void MakeDamageToPlayer()
        {
            _playerLife.TakeDamage(1);
        }
    }
}