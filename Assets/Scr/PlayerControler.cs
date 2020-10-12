using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    public float velocidad;
    public float fuerzaSalto;

    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        //Salto
        if (Input.GetKeyDown(KeyCode.W))
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
    }
}
