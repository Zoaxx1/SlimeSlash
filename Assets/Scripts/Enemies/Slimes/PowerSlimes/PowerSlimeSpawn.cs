using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSlimeSpawn : MonoBehaviour
{
    [SerializeField] private Transform spawnController;
    [SerializeField] private GameObject slime;

    public void spawnPowerSlime ()
    {
        Instantiate(slime, spawnController.position, spawnController.rotation);
    }
}
