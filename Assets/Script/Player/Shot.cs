using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //Hace referencia al controlador de disparo que esta en el jugador
    [SerializeField] private Transform ControladorDisparo;
    //Hace referencia al objeto bala
    [SerializeField] private GameObject bala;

    //Efecto de sonido
    public GameObject SoundEffectShot;

    private void Start()
    {
        SoundEffectShot.SetActive(false);
    }
    private void Update()
    {
        //Detecta si estas tocando el clik izquierdo del maus
        if (Input.GetButtonDown("Fire1"))
        {
            //Disparar
            Disparar();
            SEM();

        }
        if (!Input.GetButton("Fire1"))
        {
            SEMSTOP();
        }
    }

    private void Disparar()
    {
        Instantiate(bala, ControladorDisparo.position, ControladorDisparo.rotation);
    }

    void SEM()
    {
        SoundEffectShot.SetActive(true);
    }

    void SEMSTOP()
    {
        SoundEffectShot.SetActive(false);
    }
}
