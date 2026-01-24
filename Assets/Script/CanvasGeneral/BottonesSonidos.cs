using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonesSonidos : MonoBehaviour
{
    private AudioSource music;

    //Efecto de sonido cuando el jugador pasa el maus por ensima del boton
    public AudioClip SwitchAudio;

    //Efecto de sonido cuando el jugador pasa el maus por ensima del boton
    public AudioClip SwitchAudio_2;

    //Variante de efecto de sonido cuando el jugador le de clik al boton
    public AudioClip SwitchAudio_3;

    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    public void SwitchAudioOn()
    {
        music.PlayOneShot(SwitchAudio);
    }

    public void SwitchAudioOn_2()
    {
        music.PlayOneShot(SwitchAudio_2);
    }

    public void SwitchAudioOn_3()
    {
        music.PlayOneShot(SwitchAudio_3);
    }
}
