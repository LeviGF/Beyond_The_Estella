using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Cambio : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;

    private Player_life playerlife;


    private void Start()
    {
        playerlife = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_life>();
        playerlife.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e)
    {
       GameOver.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CambiarEscena(string nombre)
    {
        if (Desbloquear_Niveles.Instancias != null)
        {
            Desbloquear_Niveles.Instancias.AumentarNivel();
        }
        SceneManager.LoadScene(nombre);
    }
}
