using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public interface IBulletMover
    {
        void Configure(float speed);

        Vector3 GetDirection(Transform transform);
    }
}