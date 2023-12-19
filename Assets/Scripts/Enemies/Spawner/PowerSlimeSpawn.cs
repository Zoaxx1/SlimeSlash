using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSlimeSpawn : MonoBehaviour
{
    [SerializeField] private Transform _spawnController;
    [SerializeField] private GameObject _slime;
    [SerializeField] private float _timeToSpawn;
    public void SpawnPowerSlime ()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_timeToSpawn);
        Instantiate(_slime, _spawnController.position, _spawnController.rotation);
    }
}
