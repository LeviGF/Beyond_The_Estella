using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_sounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip click_sound; //Efecto de sonido cuando haces click en el boton
    public AudioClip pass_maus_sound; //Efecto de sonido cuando pasas con el maus arriba del boton

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
    }

    public void ClickSound()
    {
        audioSource.PlayOneShot(click_sound);
    }

    public void PassMausSound()
    {
        audioSource.PlayOneShot(pass_maus_sound);
    }
}
