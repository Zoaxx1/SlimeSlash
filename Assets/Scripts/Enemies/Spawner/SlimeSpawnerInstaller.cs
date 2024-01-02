using Assets.Scripts.Enemies.Slimes;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public class SlimeSpawnerInstaller : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;

        [SerializeField] private Transform _spawnerTransform;

        [SerializeField] private Slime[] _slimes;
        [SerializeField] private SlimePrefabConfigurer _slimePrefabConfigurer;

        [Header("Time To Spawn Configuration")]
        [SerializeField] private bool _useContinueSpawnerWithTimer;
        [SerializeField] private float _timeToSpawn;
        [Range(1f, 9f)][SerializeField] private float _minTimeToSpawn;
        [Range(2f, 10f)][SerializeField] private float _maxTimeToSpawn;
        private ITimeSpawner _timeSpawner;

        [Header("Change Position Before Spawn Configuration")]
        [SerializeField] private bool _changePositionBeforeSpawn;
        [SerializeField] private float _minPositionToSpawnX;
        [SerializeField] private float _maxPositionToSpawnX;

        private void Awake()
        {
            if(_useContinueSpawnerWithTimer)
            {
                _timeSpawner = new ContinueSpawner(_minTimeToSpawn, _maxTimeToSpawn);
            } else
            {
                _timeSpawner = new OneTimeSpawner(_timeToSpawn);
            }
            _spawner.Configure(
                _spawnerTransform,
                _slimePrefabConfigurer,
                _slimes,
                _timeSpawner,
                _changePositionBeforeSpawn,
                _minPositionToSpawnX,
                _maxPositionToSpawnX
                );
        }
    }
}