using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDestroyer : MonoBehaviour
{
    SlimeLife _slimeLife;

    private void Start()
    {
        _slimeLife = GetComponent<SlimeLife>();
    }


    private void Update()
    {
        if(_slimeLife.Life == 0)
        {
            Destroy(gameObject);
        }
    }
}
