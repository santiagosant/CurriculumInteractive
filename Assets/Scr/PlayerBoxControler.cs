using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoxControler : MonoBehaviour
{

    public float velocidad;
    public float fuerzaSalto;
    public float maximaVelocidad;

    Rigidbody2D rb;

    bool ground;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        //Salto
        if (Input.GetKeyDown(KeyCode.W) && ground)
        {
            rb.AddForce(new Vector2(0, fuerzaSalto), ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        //Movimiento
        float movX;
        movX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(velocidad * movX, rb.velocity.y);
        //Limitacion de velocidad
        float limitedSpeed = Mathf.Clamp(rb.velocity.x, -maximaVelocidad, maximaVelocidad);
        rb.velocity = new Vector2(limitedSpeed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            ground = false;
        }
    }
}
