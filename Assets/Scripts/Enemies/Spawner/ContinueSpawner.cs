using Assets.Scripts.Enemies.Spawner;
using UnityEngine;

public class ContinueSpawner : ITimeSpawner
{
    private float _minTimeToSpawn;
    private float _maxTimeToSpawn;
    private float _time;

    public ContinueSpawner(
        float minTimeToSpawn,
        float maxTimeToSpawn
        )
    {
        _minTimeToSpawn = minTimeToSpawn;
        _maxTimeToSpawn = maxTimeToSpawn;
        _time = GetRandomTime();
    }

    private float GetRandomTime()
    {
        return Random.Range(_minTimeToSpawn, _maxTimeToSpawn);
    }

    public bool TimeDownToSpawn()
    {
        float timeLess = Time.time - _time;
        if (timeLess > 0)
        {
            _time = Time.time  + GetRandomTime();
            return false;
        }
        return true;
    }
}
