using Assets.Scripts.Enemies.Slimes.General;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeFallen : ISlimeMover
{
    public Vector2 GetDirection(Transform transform)
    {
        return transform.position;
    }
}
