using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausar : MonoBehaviour
{

    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausa()
    {
        Time.timeScale = 0f;

        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Continuar()
    {
        Time.timeScale = 1f;

        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    
}
