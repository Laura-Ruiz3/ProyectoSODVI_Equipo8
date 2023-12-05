using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Objetos : MonoBehaviour
{
    public GameObject[] obstaculos;
    public GameObject[] comida;

    public float tiempoSpawn_Obs = 2;
    public float repetirSpawn_Obs;
    public float posisionGen_Obs;

    public Transform GenAbajoD;
    public Transform GenAbajoI;
    public Transform GenArribaD;
    public Transform GenArribaI;

    public float tiempoSpawn_Com = 10;
    public float repetirSpawn_Com;
    public float posisionGen_Com;

    public Transform GenAbajo;
    public Transform GenArriba;

    // Start is called before the first frame update
    void Start()
    {
        repetirSpawn_Obs = Random.Range(2, 3);
        InvokeRepeating("SpawnObjetos", tiempoSpawn_Obs, repetirSpawn_Obs);
        repetirSpawn_Com = 10;
        InvokeRepeating("SpawnComida", tiempoSpawn_Com, repetirSpawn_Com);
    }

    // Update is called once per frame
    void Update()
    {
        repetirSpawn_Obs = Random.Range(2, 3);
        //print(repetirSpawn_Obs);
        repetirSpawn_Com = Random.Range(10, 20);
        //print(repetirSpawn_Com);
    }

    public void SpawnObjetos()
    {
        Vector2 spawnPosision_Obs = new Vector2(0, 0);

        posisionGen_Obs = Random.Range(0, 4);
        if(posisionGen_Obs == 1)
        {
            spawnPosision_Obs = new Vector2(Random.Range(GenArribaI.position.x, GenArribaD.position.x), GenArribaD.position.y);
            GameObject obstaculo = Instantiate(obstaculos[Random.Range(0, 3)], spawnPosision_Obs, gameObject.transform.rotation);
        }
        else
        {
            spawnPosision_Obs = new Vector2(Random.Range(GenAbajoI.position.x, GenAbajoD.position.x), GenAbajoD.position.y);
            GameObject obstaculo = Instantiate(obstaculos[Random.Range(0, 3)], spawnPosision_Obs, gameObject.transform.rotation);
        }
        
    }

    public void SpawnComida()
    {
        Vector2 spawnPosision_Com = new Vector2(0, 0);
        posisionGen_Com = Random.Range(0, 3);
        if (posisionGen_Com == 1)
        {
            spawnPosision_Com = new Vector2(GenAbajo.position.x, GenAbajo.position.y);
            GameObject obstaculo = Instantiate(comida[Random.Range(0, 3)], spawnPosision_Com, gameObject.transform.rotation);
        }
        else if (posisionGen_Com == 2)
        {
            spawnPosision_Com = new Vector2(GenArriba.position.x, GenArriba.position.y);
            GameObject obstaculo = Instantiate(comida[Random.Range(0, 3)], spawnPosision_Com, gameObject.transform.rotation);
        }
    }
}
