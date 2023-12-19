using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes.General
{
    public class SlimeMoverRight: ISlimeMover
    {
        private float _speed;

        public SlimeMoverRight(float speed)
        {
            _speed = speed;
        }

        Vector2 ISlimeMover.GetDirection(Transform transform)
        {
            return transform.position + transform.right * _speed * Time.fixedDeltaTime;
        }
    }
}