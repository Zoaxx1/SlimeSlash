using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5.0f;

    [SerializeField] private float _jumpForce = 15f;
    [SerializeField] private float _gravityScaleInJump = 3f;
    [SerializeField] private float _gravityScaleOutJump = 5f;

    private Rigidbody2D _rb;

    private IPlayerMoveChanger _playerInput;
    private IPlayerMoveChanger _playerRotate;
    private IPlayerMoveChanger _playerJump;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

        _playerInput = new PlayerInput(_speed, _rb);
        _playerRotate = new PlayerRotate(transform);
        _playerJump = new PlayerJump(_jumpForce, _gravityScaleInJump, _gravityScaleOutJump, _rb);
    }

    private void Update()
    {
        _playerInput.MoveChange();
        _playerRotate.MoveChange();
        _playerJump.MoveChange();
    }
}
