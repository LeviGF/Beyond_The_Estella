using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiiepo_de_vida : MonoBehaviour
{
    [SerializeField] private float TiempoDeVida;


    void Start()
    {
        Destroy(gameObject, TiempoDeVida);
    }
}
