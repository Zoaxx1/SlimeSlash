using Assets.Scripts.Enemies.Slimes;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Spawner
{
    public interface ISlimePrefabConfigurer
    {
        Slimes.Slime GetSlimePrefab(string id);
    }
}