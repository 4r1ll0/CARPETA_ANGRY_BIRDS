using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlLanzamiento : MonoBehaviour
{
    
    public Rigidbody2D pivote;
    public GameObject bola;
    
    private Camera camara;
    private Rigidbody2D bolaRigidbody;
    private float tiempoQuitarSprintJoin;
    private SpringJoint2D bolaSprintJoint;

    private bool estaArrastrando;

    void Start()
    {
        camara = Camera.main;

        bolaRigidbody = bola.GetComponent<Rigidbody2D>();
        bolaSprintJoint = bola.GetComponent<SpringJoint2D>();

        bolaSprintJoint.connectedBody = pivote;
    }

    void Update()
    {
        if (bolaRigidbody == null) { return; }

       if (!Touchscreen.current.primaryTouch.press.isPressed)
       {
            if (estaArrastrando)
            {
                LanzarBola();
            }

            estaArrastrando = false;

            return;
       }

        estaArrastrando = true;

        bolaRigidbody.isKinematic = true;

        Vector2 posicionTocar = Touchscreen.current.primaryTouch.position.ReadValue();
        Vector3 posicionMundo = camara.ScreenToWorldPoint(posicionTocar);

        Debug.Log(posicionMundo);
    }   

    private void LanzarBola()
    {
        bolaRigidbody.isKinematic = false;
        bolaRigidbody = null;

        Invoke(nameof(QuitarSprintJoin), tiempoQuitarSprintJoin);
    }

    private void QuitarSprintJoin()
    {
        
    }

}
