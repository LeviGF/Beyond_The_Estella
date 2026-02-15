using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo_Life : MonoBehaviour
{
    [SerializeField] private float vida_Max;
    private float vida;
    private Rigidbody2D rb;
    void Start()
    {
        vida = vida_Max;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void TomarDaño(float CantidadDaño)
    {
        vida -= CantidadDaño;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
