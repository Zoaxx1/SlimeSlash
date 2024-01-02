using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Enemies.Slimes.General
{
    public interface ISlimeMover
    {
        Vector2 GetDirection(Transform transform);
    }
}