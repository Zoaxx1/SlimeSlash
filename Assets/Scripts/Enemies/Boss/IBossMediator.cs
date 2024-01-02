using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Boss
{
    public interface IBossMediator
    {
        void PowerUpCollisionWithBoss();

        void GrowUpCountIsEqualToZero();
    }
}