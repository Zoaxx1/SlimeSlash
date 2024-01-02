﻿using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes.General
{
    public class SlimeMoverLeft : ISlimeMover
    {

        private float _speed;

        public SlimeMoverLeft(float speed)
        {
            _speed = speed;
        }

        public Vector2 GetDirection(Transform transform)
        {
            return transform.position + (transform.right * -1) * _speed * Time.fixedDeltaTime;
        }
    }
}