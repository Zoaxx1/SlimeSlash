using Assets.Scripts;
using UnityEngine;

public class BossLife : MonoBehaviour, IDamaged
{
    [SerializeField] private float life = 100;

    public float Life
    {
        get { return life; }
    }

    public void TakeDamage(float damage)
    {
        life -= damage;
    }
}
