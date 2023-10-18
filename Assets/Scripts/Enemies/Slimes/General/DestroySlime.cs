using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlime : MonoBehaviour
{
    [SerializeField] private string tagName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(tagName))
        {
            if(collision.gameObject.CompareTag("Wall"))
            {
                collision.gameObject.GetComponent<PowerSlimeSpawn>().spawnPowerSlime();
            }
            Destroy(gameObject);
        }
    }
}
