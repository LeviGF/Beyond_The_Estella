using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Desbloquear_Niveles : MonoBehaviour
{
    // Volviendolo una Instancia el Scrip
    public static Desbloquear_Niveles Instancias;

    //Aqui ponemos los botones a los niveles
    public Button[] Botones_Niveles;
    public int DesbloquearNivel;

    //Seguro de Instancia (Solo puede haber una instancia por escena)
    public void Awake()
    {
        if(Instancias == null)
        {
            Instancias = this;
        }
    }

    void Start()
    {
        //Todo lo refeerente a la lista de botones
        if(Botones_Niveles.Length > 0)
        {
            for (int i = 0; i < Botones_Niveles.Length; i++)
            {
                Botones_Niveles[i].interactable = false;
            }

            for (int i=0; i <PlayerPrefs.GetInt("nivelesDesbloqueados", 1); i++)
            {
                Botones_Niveles[i].interactable = true;
            }
        }
    }

    //Esta funcion se ocupa para aumentar el valor ("nivelesDesbloqueados") 
    public void AumentarNivel()
    {
        if(DesbloquearNivel > PlayerPrefs.GetInt("nivelesDesbloqueados", 1))
        {
            PlayerPrefs.SetInt("nivelesDesbloqueados", DesbloquearNivel);
        }
    }

}
