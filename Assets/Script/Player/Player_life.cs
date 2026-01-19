using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_life : MonoBehaviour
{
    [SerializeField] private int vida;
    public event EventHandler MuerteJugador; //Funcion Afirma la muerte del jugador
    //public bool pausarjuego = false;

    public void TomarDaño(int cantidadDaño)
    {
        vida -= cantidadDaño;
        if (vida <= 0)
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        }
    }

    /*public void Pausar()
    {
        Time.timeScale = 0;
        pausarjuego = true;
    }*/
}
