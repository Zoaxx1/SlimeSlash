using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFired : MonoBehaviour
{
    [SerializeField] private Transform fireController;
    [SerializeField] private GameObject bullet;

    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, fireController.position, fireController.rotation);
        }
    }
}
