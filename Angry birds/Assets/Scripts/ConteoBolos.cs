using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConteoBolos : MonoBehaviour
{
    private class cuantos = 0;
    private ControlDatosJuegos datosJuego;

    void Start()
    {
        datosJuego = GameObject.Find("DatosJuego").
            GetComponent<ControlDatosJuego>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bolo"));
        {
            cuantos++;
            datosJuego.Puntuacion = cuantos;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        cuantos--;
        datosJuego.Puntuacion = cuantos;
    }
}
