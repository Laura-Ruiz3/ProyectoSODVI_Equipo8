using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Obstaculo : MonoBehaviour
{
    public float Velociad;

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
