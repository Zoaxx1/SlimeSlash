using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes.SimpleSlimes
{
    public class RandomTimer : MonoBehaviour, IRandomTimer
    {
        [SerializeField] private float _minTimeToSpawn;
        [SerializeField] private float _maxTimeToSpawn;
        private float _timeToSpawn;

        public float GetRandomTime()
        {
            return Random.Range(_minTimeToSpawn, _maxTimeToSpawn);
        }
    }
}