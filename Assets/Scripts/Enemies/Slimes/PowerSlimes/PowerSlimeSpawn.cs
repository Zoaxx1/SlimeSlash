using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSlimeSpawn : MonoBehaviour
{
    [SerializeField] private Transform spawnController;
    [SerializeField] private GameObject slime;
    [SerializeField] private float timeToSpawn;
    public void spawnPowerSlime ()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(timeToSpawn);
        Instantiate(slime, spawnController.position, spawnController.rotation);
    }
}
