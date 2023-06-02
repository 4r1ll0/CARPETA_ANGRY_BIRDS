using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDatosJuego : MonoBehaviour
{
    private int puntuacion;

    public int Puntuacion { get => puntuacion; set => puntuacion = value; }

    private void Awake()
    {
        int numInstancias = FindObjectOfType<ControlDatosJuego>().Length;

        if (numInstancias != 1)
        {
            Destroy(this.gameObject);
        }
        else 
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
