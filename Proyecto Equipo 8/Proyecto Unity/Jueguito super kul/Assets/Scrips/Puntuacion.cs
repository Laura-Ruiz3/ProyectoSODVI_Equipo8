using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public TMP_Text puntuacion;

    public float valor_p;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        valor_p += Time.deltaTime;

        puntuacion.text = "Puntuación: " + valor_p.ToString("0");
    }

    public void PuntuacionFruta(float puntuacion_f)
    {
        valor_p += puntuacion_f;
    }
}
