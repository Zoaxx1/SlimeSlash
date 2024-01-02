using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public class SlimeFactory
    {
        private readonly SlimePrefabConfigurer _slimePrefabConfigurer;
        private Vector3 _position;
        private Quaternion _rotation;

        public SlimeFactory(
            SlimePrefabConfigurer slimePrefabConfigurer,
            Vector3 position,
            Quaternion rotation
            )
        {
            _slimePrefabConfigurer = slimePrefabConfigurer;
            _position = position;
            _rotation = rotation;
        }

        public void ChangePosition(Vector3 position)
        {
            _position = position;
        }

        public Slimes.Slime Create(string id)
        {
            return Object.Instantiate(_slimePrefabConfigurer.GetSlimePrefab(id), _position, _rotation);
        }

    }
}