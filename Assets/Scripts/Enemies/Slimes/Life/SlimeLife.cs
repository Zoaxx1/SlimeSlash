using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeLife : MonoBehaviour, IDamaged
{
    [SerializeField] private float life = 3;

    public float Life {
        get { return life; }
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
    }
}
