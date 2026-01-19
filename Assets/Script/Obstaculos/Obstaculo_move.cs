using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo_move : MonoBehaviour
{
    public GameObject obstaculo;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxY);
        float Y = Random.Range(minY, maxY);

        Instantiate(obstaculo, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}
