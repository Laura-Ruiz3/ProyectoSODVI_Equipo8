using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondos: MonoBehaviour
{
    [SerializeField] private Vector2 velocidad;
    private Vector2 offset;
    private Material material;

    void Awake()
    {
        material = GetComponent<SpriteRenderer> ().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = velocidad * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
