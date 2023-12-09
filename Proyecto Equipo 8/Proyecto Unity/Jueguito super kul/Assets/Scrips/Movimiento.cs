using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] private GameObject P_Perdiste;
    [SerializeField] private GameObject menu_Pausa;

    public int FuerzaDeSalto;
    bool EnElPiso = false;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && EnElPiso)
        {
            EnElPiso = false;
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, FuerzaDeSalto));
        }

        if (EnElPiso == false)
        {
            animator.SetBool("Salto", true);
        }
        else
                {
            animator.SetBool("Salto",false);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision) 
    {
        EnElPiso = true;
        if(collision.gameObject.tag == "Obstaculo")
        {
            GameObject.Destroy(this.gameObject);

            Time.timeScale = 0f;
            P_Perdiste.SetActive(true);
            menu_Pausa.SetActive(false);
        }
    }
}
