using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Enemy_Life : MonoBehaviour
{ 
    [SerializeField] private float vidaMax; //Vima maxima del jugador
    [SerializeField] private Life_Bar lifeBar;
    private float vida; //Vida actual del jugador

    public string desbloquear;

    //private SpriteRenderer sprite;

    private void Start()
    {
        vida = vidaMax;
        lifeBar.UpdateLifeBar(vidaMax, vida);
        //sprite = GetComponent<SpriteRenderer>();
    }

    //public void TomarDaño(float CantidadDaño)
    public void TomarDaño(float CantidadDaño)
    {
        //float damageDuration = 0.1f;
        vidaMax -= CantidadDaño;
        lifeBar.UpdateLifeBar(vidaMax, vida);

        if(vidaMax <= 0)
        {
            //sprite.color = Color.red;
            //yield return new WaitForSeconds(damageDuration);
            //sprite.color = Color.white;
            //Destroy(gameObject);
            Dead();
            
        }
    }

    private void Dead()
    {
        Destroy(gameObject);
        //Comprueba si el enemigo es destruido, guarda el progreso y desbloquea el nivel
        //PlayerPrefs.SetInt("NivelDesbloqueado", 1); //1 indica que esta desbloqueado
        //PlayerPrefs.Save(); //Guarda progreso

        SceneManager.LoadScene(desbloquear);
    }
}
