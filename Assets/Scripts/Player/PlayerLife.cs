using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int life;

    void Update()
    {
        if (life == 0)
        {
            Time.timeScale = 0;
        }
    }
    public void TakeDamage()
    {
        life -= 1;
    }
}
