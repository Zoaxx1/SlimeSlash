using Assets.Scripts.Enemies.Slimes.General;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    [SerializeField] private bool _goToRight;
    private ISlimeMover _slimeMover;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (_goToRight)
        {
            _slimeMover = new SlimeMoverRight(_speed);
        }
        else
        {
            _slimeMover = new SlimeMoverLeft(_speed);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(_slimeMover.GetDirection(transform));
    }
}
