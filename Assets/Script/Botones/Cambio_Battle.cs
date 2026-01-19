using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambio_Battle : MonoBehaviour
{
    [SerializeField] private GameObject GameOver;

    private Player_life_Battle playerlifeBattle;


    private void Start()
    {
        playerlifeBattle = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_life_Battle>();
        playerlifeBattle.MuerteJugador += ActivarMenu;
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
        SceneManager.LoadScene(nombre);
    }
}
