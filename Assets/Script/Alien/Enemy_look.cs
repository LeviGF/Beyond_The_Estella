using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_look : MonoBehaviour
{
    [SerializeField] public Transform Objetivo;

    private void Update()
    {
        float anguloR = Mathf.Atan2(Objetivo.position.y - transform.position.y, Objetivo.position.x - transform.position.x); //Angulo en Radianes
        float anguloG = (180 / Mathf.PI) * anguloR - 90; //Angulo en Grados
        transform.rotation = Quaternion.Euler(0, 0, anguloG);
    }

}
