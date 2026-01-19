using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawn : MonoBehaviour
{
    public GameObject obstaculo;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float TimeBetweenSpawn;
    public float SpawnTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
            //SpawnTime = 60f;
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY, maxY);

        Instantiate(obstaculo, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
