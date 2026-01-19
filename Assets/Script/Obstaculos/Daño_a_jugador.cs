using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Daño_a_jugador : MonoBehaviour
{
    [SerializeField] private int daño;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player_life>().TomarDaño(daño);
            Destroy(gameObject);
        }
    }
}
