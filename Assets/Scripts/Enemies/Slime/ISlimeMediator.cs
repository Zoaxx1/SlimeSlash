using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes
{
    public interface ISlimeMediator
    {
        void SlimeMakeCollision();

        void SlimeTakingDamage();

        void SlimeLifeIsZero();

        void SlimeContactWithThePlayer();
    }
}