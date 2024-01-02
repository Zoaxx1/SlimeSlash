using Assets.Scripts.Enemies.Spawner;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeSpawner : ITimeSpawner
{
    private float _timeToSpawn;

    public OneTimeSpawner(float timeToSpawn)
    {
        _timeToSpawn = timeToSpawn;
    }

    public bool TimeDownToSpawn()
    {
        float time = Time.deltaTime - _timeToSpawn;
        if(time > 0)
        {
            return false;
        }
        return true;
    }
}
