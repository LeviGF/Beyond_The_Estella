using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_1 : MonoBehaviour
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


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy_life1>().TomarDaño(daño);

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
    }
}
