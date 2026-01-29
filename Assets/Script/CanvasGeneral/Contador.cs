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

    //Hace referencia a cuando se acaba el tiempo pero esta vez especifico para la barra
    private float timeLeft;

    //Tiempo maximo
    public float maxTime = 5f;

    //Referencia al alien que aparecera cuando termine el tiempo
    public GameObject AlienSpawn;

    //Barra de progresion
     public Image BarImage;

    // Start is called before the first frame update
    void Start()
    {
        ActualizarContador();
        timeLeft = maxTime;
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
        BarImg();

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

    private void BarImg()
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            //Barra de contador
            BarImage.fillAmount = timeLeft / maxTime;
        }
      
    }
}
