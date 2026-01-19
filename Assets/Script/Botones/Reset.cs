using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void Reiniciar()
    {
        //Reinicia a 0 el juego


        //Elimina todas las claves de PlayerPrefs
        PlayerPrefs.DeleteAll();
        //Guarda que todo se halla eliminado
        PlayerPrefs.Save();
    }
}
