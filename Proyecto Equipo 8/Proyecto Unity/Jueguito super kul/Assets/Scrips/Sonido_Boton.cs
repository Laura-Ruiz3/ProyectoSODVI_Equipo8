using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido_Boton : MonoBehaviour
{
    public AudioSource sonido;
    public AudioClip sonido_b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundButton()
    {
        sonido.clip = sonido_b;
        sonido.enabled = false;
        sonido.enabled = true;
    }
}
