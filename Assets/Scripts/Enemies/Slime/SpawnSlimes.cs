using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSlimes : MonoBehaviour
{
    [SerializeField] private Transform spawnController;
    [SerializeField] private GameObject slime;
    [SerializeField] private float minTimeToSpawn;
    [SerializeField] private float maxTimeToSpawn;
    private float startTime;
    private float timeToSpawn;

    private void Start()
    {
        startTime = Time.realtimeSinceStartup;
        setRandomRange();
    }

    void Update()
    {

        float passTime = Time.time - startTime;
        if(passTime >= timeToSpawn)
        {
            Instantiate(slime, spawnController.position, spawnController.rotation);
            startTime = Time.realtimeSinceStartup;
            setRandomRange();
        }
    }

    private void setRandomRange()
    {
        timeToSpawn = Random.Range(minTimeToSpawn, maxTimeToSpawn);
    }
}
