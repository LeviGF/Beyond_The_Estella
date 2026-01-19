using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Battle : MonoBehaviour
{
    //Variable velocidad
    [SerializeField]public float speed;

    //Hace referencia al Rigidbody del jugador
    private Rigidbody2D playerRB;

    //Hace referencia a los input
    private Vector2 moveInput;

    //El objetivo es el cursor del maus en este caso
    private Vector3 objetivo;

    [SerializeField] private Camera camara;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Para que el jugador siga al maus
        objetivo = camara.ScreenToWorldPoint(Input.mousePosition);
        
        float anguloR = Mathf.Atan2(objetivo.y - transform.position.y, objetivo.x - transform.position.x); //Angulo en Radianes
        float anguloG = (180 / Mathf.PI) * anguloR - 90; //Angulo en Grados
        transform.rotation = Quaternion.Euler(0, 0, anguloG);

        //Movimiento
        float moveX = Input.GetAxisRaw("Horizontal"); //Importante ocupar InputAxisRaw y no InputAxis para que cuando manejes al jugador no se deslize
        float moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
    }

    private void FixedUpdate()
    {
        playerRB.MovePosition(playerRB.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
