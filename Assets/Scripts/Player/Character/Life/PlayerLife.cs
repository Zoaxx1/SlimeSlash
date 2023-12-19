using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour, IDamaged
{
    [SerializeField] private Image _lifeBar;
    [SerializeField] private float _totalLife;
    private float _life;
    public float Life
    {
        get { return _life; }
    }

    void Start()
    {
        _life = _totalLife;
    }

    public void TakeDamage(float damage)
    {
        _life -= damage;
        _lifeBar.fillAmount = _life / _totalLife;
    }
}
