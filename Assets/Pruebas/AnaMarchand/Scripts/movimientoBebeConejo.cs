﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoBebeConejo : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;
    public float velocidadTope;
    public Transform habitacionActual;
    bool fueraDeHabitacion;
    //SpriteRenderer spritePJ;

    //Animator animPJ;


    public Vector2 vectorVelocidad;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //spritePJ = GetComponent<SpriteRenderer>();
        //animPJ = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("HabitacionElectricidad") || col.gameObject.CompareTag("HabitacionAgua") || col.gameObject.CompareTag("HabitacionComida") || col.gameObject.CompareTag("HabitacionVeterinario") || col.gameObject.CompareTag("HabitacionDormitorio") || col.gameObject.CompareTag("HabitacionPuertaEntrada") || col.gameObject.CompareTag("Habitacion"))
        {
            if (Mathf.Abs(rb.velocity.x) < velocidadTope)
            {
                rb.AddForce(vectorVelocidad * velocidad);
            }
            habitacionActual = col.transform;
            fueraDeHabitacion = false;
        }
    }


    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Habitacion"))
        {
            fueraDeHabitacion = true;
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       if (col.gameObject.CompareTag("Pared"))
       {
            velocidad = velocidad * -1;
            //spritePJ.flipX = !spritePJ.flipX;
            //Invoke("EscribirEnCuaderno", 1f);
        }
    }

    public void PararMovimiento()
    {
        vectorVelocidad.x = 0;
        Invoke("ReiniciarMovimiento", Random.Range(1f, 3f));
    }

    public void ReiniciarMovimiento()
    {
        //animPJ.SetBool("Escribir", false);
        vectorVelocidad.x = 1;
        rb.AddForce(vectorVelocidad * velocidad);
    }
}
