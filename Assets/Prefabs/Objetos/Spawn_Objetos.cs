using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Objetos : MonoBehaviour
{
    public GameObject[] obstaculos;

    public float tiempoSpawn = 2;
    public float repetirSpawn;

    public Transform GenAbajoD;
    public Transform GenAbajoI;

    // Start is called before the first frame update
    void Start()
    {
        repetirSpawn = Random.Range(3, 6);
        InvokeRepeating("SpawnEnemigos", tiempoSpawn, repetirSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        repetirSpawn = Random.Range(1, 3);
        print(repetirSpawn);
    }

    public void SpawnEnemigos()
    {
        Vector2 spawnPosision = new Vector2(0, 0);

        spawnPosision = new Vector2(Random.Range(GenAbajoI.position.x, GenAbajoD.position.x), GenAbajoD.position.y);

        GameObject obstaculo = Instantiate(obstaculos[Random.Range(0, 3)], spawnPosision, gameObject.transform.rotation);
    }
}
