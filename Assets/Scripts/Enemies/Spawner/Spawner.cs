using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public class Spawner : MonoBehaviour
    {
        private Transform _spawnerTransform;

        private SlimePrefabConfigurer _slimePrefabConfigurer;
        private Slime[] _slimes;
        private SlimeFactory _slimeFactory;

        private ITimeSpawner _timeSpawner;

        private bool _changePositionBeforeSpawn;
        private float _minPositionToSpawnX;
        private float _maxPositionToSpawnX;

        private bool _spawnNow = false;

        public void Configure(
            Transform spawnerTransform,
            SlimePrefabConfigurer slimePrefabConfigurer,
            Slime[] slimes,
            ITimeSpawner timeSpawner,
            bool changePositionBeforeSpawn,
            float minPositionToSpawnX,
            float maxPositionToSpawnX
            )
        {
            _spawnerTransform = spawnerTransform;
            _slimePrefabConfigurer = slimePrefabConfigurer;
            _slimes = slimes;
            _timeSpawner = timeSpawner;
            _changePositionBeforeSpawn = changePositionBeforeSpawn;
            _minPositionToSpawnX = minPositionToSpawnX;
            _maxPositionToSpawnX = maxPositionToSpawnX;

            _slimeFactory = new SlimeFactory(Instantiate(_slimePrefabConfigurer), _spawnerTransform.position, _spawnerTransform.rotation);
        }

        public void SpawnNow()
        {
            _spawnNow = true;
        }

        void Update()
        {
#if UNITY_EDITOR
            if (Input.GetKey(KeyCode.F1) && !_timeSpawner.TimeDownToSpawn())
            {
                _slimeFactory.Create(_slimes[0].Id);
            }
#endif
            if (!_timeSpawner.TimeDownToSpawn() || _spawnNow)
            {
                if( _changePositionBeforeSpawn )
                {
                    float randomX = Random.Range(_minPositionToSpawnX, _maxPositionToSpawnX);
                    _slimeFactory.ChangePosition(new Vector3(randomX, _spawnerTransform.position.y, _spawnerTransform.position.z));
                }
                _slimeFactory.Create(_slimes[0].Id);
                _spawnNow = false;
            }
        }
    }
}