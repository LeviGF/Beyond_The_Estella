using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    //Velocidad de la bala
    [SerializeField] private float speed;

    //Daño que hace la bala
    [SerializeField] private float daño;

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
        if (other.CompareTag("Enemy"))
        {
            //other.GetComponent<Enemy_Life>().TomarDaño(daño);
            other.GetComponent<Enemy_Life>().TomarDaño(daño);

            Destroy(gameObject);
        }

        if (other.CompareTag("Covertura"))
        {
            Destroy(gameObject);
        }

        if (other.CompareTag("Bala"))
        {
            other.GetComponent<Bala_Enemiga_1>().TomarDaño(daño);
            Destroy(gameObject);
        }

        if (other.CompareTag("Bala_Pesada"))
        {
            Destroy(gameObject);
        }
    }
}
