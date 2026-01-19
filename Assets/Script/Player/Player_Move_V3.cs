using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using UnityEngine;

public class Player_Move_V3 : MonoBehaviour
{
    public GameObject SoundEffectMove;

    public float velocidad;
    public Rigidbody2D rb;
    public float direccionX = 0f;

    //Animacion del jugador
    public Animator animator;


    void Start()
    {
        SoundEffectMove.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {

        //Apartado del movimiento
        direccionX = Input.GetAxis("Horizontal");

        animator.SetFloat("Movement", direccionX * velocidad);
        if (direccionX < 0f)
        {
            transform.localScale = new Vector3(-0.6f, 0.6f, 1f);
            SEM();
        }

        if (direccionX > 0f)
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 1f);
            SEM();
        }

        if(direccionX == 0f)
        {
            SEMSTOP();
        }
     }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direccionX * velocidad, rb.velocity.y);
    }

    void SEM()
    {
        SoundEffectMove.SetActive(true);
    }

    void SEMSTOP()
    {
        SoundEffectMove.SetActive(false);
    }
}
