using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMediator : MonoBehaviour, IPlayerMediator
{
    [SerializeField] private PlayerMove _playerInput;
    [SerializeField] private PlayerGrounded _playerGrounded;
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private PlayerRotate _playerRotate;
    [SerializeField] private PlayerShoot _playerShoot;

    private void Awake()
    {
        _playerInput.Configure(this);
        _playerGrounded.Configure(this);
        _playerJump.Configure(this);
        _playerRotate.Configure(this);
        _playerShoot.Configure(this);
    }
    private void Update()
    {
        TryMove();
        TryJump();
        TryFall();
        TryShoot();
    }

    public void TryMove()
    {
        float _xMove = _playerInput.InputHorizontalActionPressed();
        if(_xMove > 0 || _xMove < 0)
        {
            _playerInput.TryMove();
            TryRotate();
        }
    }

    public void TryJump()
    {
        if (_playerJump.InputUpActionPressed() && _playerGrounded.IsOnTheFloor)
        {
            _playerJump.TryJump();
        }
    }

    public void TryFall()
    {
        if (_playerJump.YPlayerIsLessThanZero())
        {
            _playerJump.TryFall();
        }
    }

    public void TryRotate()
    {
        if (_playerInput.XMove < 0 && !_playerRotate.RotateToRight)
        {
            _playerRotate.TryRotate();
            _playerRotate.RotateToRight = true;
        }
        else if (_playerInput.XMove > 0 && _playerRotate.RotateToRight)
        {
            _playerRotate.TryRotate();
            _playerRotate.RotateToRight = false;

        }
    }

    public void TryShoot()
    {
        if(_playerShoot.IsFireActionPressed())
        {
            _playerShoot.TryShoot();
        }
    }
}
