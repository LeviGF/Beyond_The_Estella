using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Enemiga_1 : MonoBehaviour
{
    //Velocidad de la bala
    [SerializeField] private float speed;

    //Daño que hace la bala
    [SerializeField] private int daño;

    //Vida de la Bala
    [SerializeField] public float balaVida;


    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        rb.velocity = transform.up * speed;
    }

    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position * speed * Time.deltaTime);
    }
    private void Update()
    {
        //Como saldra la bala
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player_life_Battle>().TomarDaño(daño);

            Destroy(gameObject);
        }

        if(other.CompareTag("Covertura"))
        {
            Destroy(gameObject);
        }
    }

    public void TomarDaño(float cantidadDaño)
    {
        balaVida -= cantidadDaño;

        if (balaVida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
