using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSlimeBullets : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float minPositionX;
    [SerializeField] private float maxPositionX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.PingPong(Time.time * speed, maxPositionX - minPositionX) + 
            minPositionX, transform.position.y, transform.position.z);
    }
}
