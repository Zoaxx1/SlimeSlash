using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player.Bullet
{
    public class BulletMover : MonoBehaviour, IBulletMover
    {
        private float _speed;

        public void Configure(float speed)
        {
            _speed = speed;
        }

        public Vector3 GetDirection(Transform transform)
        {
            return transform.position + transform.right * _speed * Time.fixedDeltaTime;
        }
    }
}