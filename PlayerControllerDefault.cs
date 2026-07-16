using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerScript : MonoBehaviour
{
    // 1. DEFINIMOS LAS VARIABLES (lo que está subrayado en rosa en tu imagen)
    // Esto nos permite cambiar la velocidad desde el editor de Unity
    public float velocidadMovimiento = 5.0f;
    public float velocidadGiro = 100.0f;

    void Start()
    {
        // Aquí no necesitamos poner nada para el movimiento básico
    }

    // 2. EN EL UPDATE ESCRIBIMOS EL CÓDIGO DE TU SEGUNDA IMAGEN
    void Update()
    {
        // Si pulsamos la flecha de ARRIBA, nos movemos hacia adelante
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }

        // Si pulsamos la flecha de ABAJO, nos movemos hacia atrás
        if (Input.GetKey("down"))
        {
            transform.Translate(-Vector3.forward * velocidadMovimiento * Time.deltaTime);
        }

        // Si pulsamos la flecha IZQUIERDA, rotamos hacia la izquierda
        if (Input.GetKey("left"))
        {
            transform.Rotate(Vector3.up, -velocidadGiro * Time.deltaTime);
        }

        // Si pulsamos la flecha DERECHA, rotamos hacia la derecha
        if (Input.GetKey("right"))
        {
            transform.Rotate(Vector3.up, velocidadGiro * Time.deltaTime);
        }
    }
}