using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Comida : MonoBehaviour
{
    public GameObject[] comida;

    public float tiempoSpawn = 10;
    public float repetirSpawn;
    public float posisionGen;

    public Transform GenAbajo;
    public Transform GenArriba;


    // Start is called before the first frame update
    void Start()
    {
        repetirSpawn = 10;
        InvokeRepeating("SpawnComida", tiempoSpawn, repetirSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        repetirSpawn = Random.Range(10, 20);
        print(repetirSpawn);
    }

    public void SpawnComida()
    {
        Vector2 spawnPosision = new Vector2(0, 0);

        posisionGen = Random.Range(0, 3);
        if(posisionGen == 1)
        {
            spawnPosision = new Vector2(GenAbajo.position.x, GenAbajo.position.y);
            GameObject obstaculo = Instantiate(comida[Random.Range(0, 3)], spawnPosision, gameObject.transform.rotation);
        }
        else if(posisionGen == 2)
        {
            spawnPosision = new Vector2(GenArriba.position.x, GenArriba.position.y);
            GameObject obstaculo = Instantiate(comida[Random.Range(0, 3)], spawnPosision, gameObject.transform.rotation);
        }

        
    }

}
