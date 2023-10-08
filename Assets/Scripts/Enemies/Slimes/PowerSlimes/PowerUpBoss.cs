using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBoss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Boss"))
        {
            collision.gameObject.GetComponent<BossPowerUp>().PowerUp();
        }
    }
}
