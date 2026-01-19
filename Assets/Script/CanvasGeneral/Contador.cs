using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    //Hace referencia al contador
    public Text contador;
    //Hace referencia a los minutos
    public float minutos;
    //Hace referencia a los sugundos
    public float segundos;

    //Hce referencia a que se acabo el tiempo
    public bool timeEnd;

    //Referencia al alien que aparecera cuando termine el tiempo
    public GameObject AlienSpawn;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarContador();
    }

    // Update is called once per frame
    void Update()
    {
        if(timeEnd == true)
        {
            contador.text = "DANGER!";
            return;
        }

        segundos -= Time.deltaTime;
        if (segundos <= 0)
        {
            if (minutos == 0)
            {
                Accion();
            }
            else
            {
                segundos = 60;
                minutos -= 1;
            }
        }

        ActualizarContador();

    }

    private void ActualizarContador()
    {
        if (segundos < 10)
        {
            contador.text = minutos.ToString() + ":0" + segundos.ToString("f0");
        }
        else
        {
            contador.text = minutos.ToString() + ":" + segundos.ToString("f0");
        }
    }

    public void Accion()
    {
        timeEnd = true;
        AlienSpawn.SetActive(true);
    }

}
