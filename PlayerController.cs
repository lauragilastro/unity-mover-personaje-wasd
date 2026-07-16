using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JugadorController : MonoBehaviour {
//Declarlo la variable de tipo RigidBody que luego asociaremos a nuestro Jugador
private Rigidbody rb;
//Declaro la variable pública velocidad para poder modificarla desde la Inspector window
public float velocidad;
// Use this for initialization
void Start () {
//Capturo esa variable al iniciar el juego
rb = GetComponent<Rigidbody>();
}
// Update is called once per frame
void Update () {
//Estas variables nos capturan el movimiento en horizontal y vertical de nuestro teclado o mouse
float movimientoH = Input.GetAxis("Horizontal");
float movimientoV = Input.GetAxis("Vertical");
//Un vector 3 es un trío de posiciones en el espacio XYZ, en este caso el que corresponde al movimiento
Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);
//Asigno ese movimiento o desplazamiento a mi RigidBody, multiplicado por la velocidad que quiera darle
rb.AddForce(movimiento * velocidad);
}
}