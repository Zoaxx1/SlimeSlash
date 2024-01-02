using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    [CreateAssetMenu(menuName = "Create SlimePrefabConfigurer", fileName = "SlimePrefabConfigurer", order = 0)]
    public class SlimePrefabConfigurer : ScriptableObject, ISlimePrefabConfigurer
    {
        [SerializeField] private Slime[] _slimePrefabs;
        private Dictionary<string, Slime> _idToSlimePrefab;

        private void Awake()
        {
            _idToSlimePrefab = new Dictionary<string, Slime>();
            foreach(var slimePrefab in _slimePrefabs)
            {
                _idToSlimePrefab.Add(slimePrefab.Id, slimePrefab);
            }
        }

        public Slime GetSlimePrefab(string id)
        {
            return _idToSlimePrefab[id];
        }
    }
}