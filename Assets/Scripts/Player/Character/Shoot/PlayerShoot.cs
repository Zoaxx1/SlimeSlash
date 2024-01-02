using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private float _timeToShoot;
    [SerializeField] private Transform fireController;
    [SerializeField] private GameObject bullet;

    private float _time;

    private IPlayerMediator _player;

    public void Configure(IPlayerMediator player)
    {
        _player = player;
    }

    public bool IsFireActionPressed()
    {
        return Input.GetButtonDown("Fire1");
    }

    public void TryShoot()
    {
        if(_time > 0)
        {
            return;
        }
        Shoot();
    }

    private void Shoot()
    {
        _time = _timeToShoot;
        Instantiate(bullet, fireController.position, fireController.rotation);
    }

    private void Update()
    {
        _time -= Time.deltaTime;
    }
}
