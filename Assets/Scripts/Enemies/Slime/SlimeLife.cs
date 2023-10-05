using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeLife : MonoBehaviour
{
    [SerializeField] private float life = 3;
    public void TakeDamage()
    {
        life--;
        if (life == 0)
        {
            Destroy(gameObject);
        }
    }
}
