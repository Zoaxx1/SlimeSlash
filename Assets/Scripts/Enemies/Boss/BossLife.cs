using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLife : MonoBehaviour
{
    [SerializeField] private int life = 100;

    void Update()
    {
        if (life == 0)
        {
            GameOver.Instance.endGame(true);
        }
    }

    public void TakeDamage(int damage)
    {
        life -= damage;
    }
}
