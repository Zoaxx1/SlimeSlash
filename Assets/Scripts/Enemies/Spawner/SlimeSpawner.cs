using Assets.Scripts.Enemies.Slimes.SimpleSlimes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _slime;
    [SerializeField] private Transform _spawnerTransform;

    [SerializeField] private RandomTimer _randomTimer;
    private float _time;

    private void Start()
    {
        _time = _randomTimer.GetRandomTime();
    }

    void Update()
    {
        float timeLess = Time.time - _time;
        if (timeLess > 0)
        {
            Instantiate(_slime, _spawnerTransform.position, _spawnerTransform.rotation);
            _time = Time.time  + _randomTimer.GetRandomTime();
        }
    }
}
