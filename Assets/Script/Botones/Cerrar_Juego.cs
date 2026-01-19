using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerrar_Juego : MonoBehaviour
{
    public void FuncionCerrarJuego()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
