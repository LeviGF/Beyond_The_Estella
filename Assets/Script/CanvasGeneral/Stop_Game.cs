using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Game : MonoBehaviour
{
    public GameObject Pausa; //Hace referencia al objeto del menu pausa
    public bool juegoPausado = false; // Verifica que este desactivado el menu de pausa

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //verifica si la tecla"Escape" esta siendo preciona
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Reanudar()
    {
        Pausa.SetActive(false);
        Time.timeScale = 1;
        juegoPausado = false;
    }

    public void Pausar()
    {
        Pausa.SetActive(true);
        Time.timeScale = 0;
        juegoPausado = true;
    }
}
