using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Obstaculo : MonoBehaviour
{
    public float Velociad;
    public float incrementoV = 0.00002f;

    public float tiempo = 0f;
    public float tiempoNivel = 20;
    public float incrementoTN = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(Velociad, 0);
    }

    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
