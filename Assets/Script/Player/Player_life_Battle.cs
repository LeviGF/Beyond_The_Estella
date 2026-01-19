using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class Player_life_Battle : MonoBehaviour
{
    [SerializeField] private int vidaMax;
    private float vida;
    [SerializeField] private Life_Bar lifebar;
    public event EventHandler MuerteJugador; //Funcion Afirma la muerte del jugador

    private void Start()
    {
        vida = vidaMax;
        lifebar.UpdateLifeBar(vidaMax, vida);
    }

    public void TomarDaño(int cantidadDaño)
    {
        vidaMax -= cantidadDaño;
        lifebar.UpdateLifeBar(vidaMax, vida);
        if (vidaMax <= 0)
        {
            MuerteJugador?.Invoke(this, EventArgs.Empty);
            Destroy(gameObject);
        }
    }
}
