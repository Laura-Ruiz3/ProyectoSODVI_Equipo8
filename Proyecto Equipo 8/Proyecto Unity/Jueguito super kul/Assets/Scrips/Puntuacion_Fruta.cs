using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion_Fruta : MonoBehaviour
{
    public float punt_frutas;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Personaje"))
        {
            FindObjectOfType<Puntuacion>().PuntuacionFruta(punt_frutas);
        }
    }
}
