using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Timers;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    //Lo conecto con el script de efectos de sonido
    private Player_Sounds_Controler PlayerSoundsControler;
    //public Player_Sounds_Controler player_Sounds_Controler;
    //public bool step1 = false;
    //float timeByStep = 0.5f;
    //float count = 0f;

    public float velocidad;
    public Rigidbody2D rb;
    public float direccionX = 0f;

    //Animacion del jugador
    public Animator animator;



    //private bool Move_now;
    //private Vector3 posicion_inicial;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        //posicion_inicial = transform.position;
    }

    private void Update()
    {
        MovePlayer();
    }

    private void Awake()
    {
        PlayerSoundsControler = FindObjectOfType<Player_Sounds_Controler>();
    }

    private void MovePlayer()
    {
        //MovePlayer();

        //Apartado de efectos de sonido
        /*float velocidad = Input.GetAxis("Horizontal") * Time.deltaTime;

        if (velocidad !=0)
        {
            count += Time.deltaTime;
            if (count >= timeByStep)
            {
                if (step1)
                {
                    player_Sounds_Controler.Nave_Moviendose();
                }
                else
                {
                    player_Sounds_Controler.Nave_Moviendose();
                }
                step1 = !step1;
            }

        }*/


        //Apartado del movimiento
        direccionX = Input.GetAxis("Horizontal");

        animator.SetFloat("Movement", direccionX * velocidad);
        if(direccionX < 0f)
        {
            //player_Sounds_Controler.Nave_Moviendose();
            transform.localScale = new Vector3 (-0.6f , 0.6f , 1f);
            //PlayerSoundsControler.SelecionAudio(0, 0.5f);
        }
        if(direccionX > 0f)
        {
            //player_Sounds_Controler.Nave_Moviendose();
            transform.localScale = new Vector3(0.6f, 0.6f, 1f);
            //PlayerSoundsControler.SelecionAudio(0, 0.5f);
        }

        
        
        //rb.AddForce(Vector2.right * velocidad * multiplicador * X);
        //Moverse();
        //movimiento();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(direccionX * velocidad, rb.velocity.y);
    }

    /*private void MovePlayer()
    {
        //Apartado de efectos de sonido
        float velocidad = Input.GetAxis("Horizontal") * Time.deltaTime;

        if (velocidad != 0)
        {
            count += Time.deltaTime;
            if (count >= timeByStep)
            {
                if (step1)
                {
                    player_Sounds_Controler.Nave_Moviendose();
                }
                else
                {
                    player_Sounds_Controler.Nave_Moviendose();
                }
                step1 = !step1;
            }

        }


        //Apartado del movimiento
        direccionX = Input.GetAxis("Horizontal");

        animator.SetFloat("Movement", direccionX * velocidad);
        if (direccionX < 0f)
        {
            //player_Sounds_Controler.Nave_Moviendose();
            transform.localScale = new Vector3(-0.6f, 0.6f, 1f);
        }
        if (direccionX > 0f)
        {
            //player_Sounds_Controler.Nave_Moviendose();
            transform.localScale = new Vector3(0.6f, 0.6f, 1f);
        }

        //rb.AddForce(Vector2.right * velocidad * multiplicador * X);
        //Moverse();
        //movimiento();
    }*/

    /*void Moverse()
    {
        //Detecta la tecla
        if (Input.GetKeyDown(KeyCode.D) && !Move_now)
        {
            derecha();
        }

        if (Input.GetKeyDown(KeyCode.A) && !Move_now)
        {
            izquierda();
        }
    }

    //El movimiento a la derecha
    void derecha()
    {
        transform.position = new Vector3(transform.position.x + velocidad, transform.position.y, transform.position.z);
        Move_now = true;
    }

    //El movimiento a la izquierda
    void izquierda()
    {
        transform.position = new Vector3(transform.position.x - velocidad, transform.position.y, transform.position.z);
        Move_now = true;
    }*/


    /*void movimiento()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(velocidad, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-velocidad, 0, 0);
        }

        //rb.position = new Vector2(rb.position.y, Mathf.Clamp(rb.position.x, -6f, 4f));
    }*/
}
