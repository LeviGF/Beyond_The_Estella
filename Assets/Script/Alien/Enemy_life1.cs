using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class Enemy_life1 : MonoBehaviour
{
    [SerializeField] private float vida;

    public string desbloquear;

    public void TomarDaño(float CantidadDaño)
    {
        vida -= CantidadDaño;

        if (vida <= 0)
        {
            //Destroy(gameObject);
            Dead();
        }
    }

    private void Dead()
    {
        Destroy(gameObject);
        //Comprueba si el enemigo es destruido, guarda el progreso y desbloquea el nivel
        //PlayerPrefs.SetInt("NivelDesbloqueado", 2); //1 indica que esta desbloqueado
        //PlayerPrefs.Save(); //Guarda progreso

        SceneManager.LoadScene(desbloquear);
    }
}
