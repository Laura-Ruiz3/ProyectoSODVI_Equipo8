using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public int FuerzaDeSalto;
    bool EnElPiso = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && EnElPiso)
        {
            EnElPiso = false;
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FuerzaDeSalto));
        }  


    }

    private void OnCollisionEnter2D (Collision2D collision) {
        EnElPiso = true;
        if(collision.gameObject.tag == "Obstaculo")
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}