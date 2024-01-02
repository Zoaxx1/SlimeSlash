using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.DamagePlayer
{
    public interface IDamagePlayer
    {
        void Configure(ISlimeMediator slimeMediator);

        void MakeDamageToPlayer();
    }
}