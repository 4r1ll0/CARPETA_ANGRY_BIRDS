using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlFinNivel : MonoBehaviour
{
    public TextMeshProUGUI mensajeFinalTexto;
    private ControlDatosJuego datosjuego;
    
    void Start()
    {
        datosjuego = GameObject.Find("DatosJuego")
            .GetComponent<ControlDatosJuego>();
        string mensajeFinal = "Numero de Bolos : " + datosjuego.Puntuacion;
        if (datosjuego.Puntuacion == 6)
            mensajeFinal += "\n\n¡¡¡ ENORABUENA !!!";

        mensajeFinalTexto.text = mensajeFinal;  
    }


}
