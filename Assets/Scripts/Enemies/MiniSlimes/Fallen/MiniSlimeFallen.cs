using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniSlimeFallen : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private float _minPositionX;
    [SerializeField] private float _maxPositionX;

    void Update()
    {
        transform.position = new Vector3(
            Mathf.PingPong(
                Time.time * _speed, _maxPositionX - _minPositionX) + _minPositionX,
                transform.position.y, transform.position.z
            );
    }
}
