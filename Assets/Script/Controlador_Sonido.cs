using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador_Sonido : MonoBehaviour
{
    public static Controlador_Sonido Instance; //Con esto demas scipt pueden acceder a las funciones de este
    private AudioSource audioSource;

    public void EjecutarSonido(AudioClip sonido )
    {
        audioSource.PlayOneShot(sonido);
    }
}
