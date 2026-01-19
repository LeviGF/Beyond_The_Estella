using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Sounds_Controler : MonoBehaviour
{
    public AudioSource audioSource; //Aqui se coloca la slida del audio
    [SerializeField] private AudioClip[] audios; //Lista de los audios

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void SelecionAudio (int indice, float volumen)
    {
        audioSource.PlayOneShot(audios[indice], volumen);
    }
    //public AudioClip NaveMoviendose;
    //public AudioClip Disparo;

    /*public void Nave_Moviendose()
    {
        audioSource.PlayOneShot(NaveMoviendose);
    }*/

    /*public void Nave_Disparo()
    {
        audioSource.PlayOneShot(Disparo);
    }*/
}
