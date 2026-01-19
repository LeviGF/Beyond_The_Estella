using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_Alien : MonoBehaviour
{
    [SerializeField] public GameObject bala;
    [SerializeField] public Transform Controlador;
    private float Spawn_Time;
    public float TimeBetweenSpawn;

    void Update()
    {
      if (Time.time > Spawn_Time)
        {
            dispara();
            Spawn_Time = Time.time + TimeBetweenSpawn;
        }  
    }

    private void dispara()
    {
        Instantiate(bala, Controlador.position, Controlador.rotation);
    }
}
