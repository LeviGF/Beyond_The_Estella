using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo_Life : MonoBehaviour
{
    public float vida;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bala_Player"))
        {
            Destroy(gameObject);
        }
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
