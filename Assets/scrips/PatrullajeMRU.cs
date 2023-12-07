using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullajeMRU : MonoBehaviour
{
    public List<Transform> puntosDePatrulla; // Cambiamos de arreglo a lista
    public float velocidad = 5.0f;
    private int puntoActual = 0;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (puntosDePatrulla.Count == 0) return; // Cambiamos Length por Count

        Vector3 direccion = (puntosDePatrulla[puntoActual].position - transform.position).normalized;
        rb.velocity = direccion * velocidad;

        if (Vector3.Distance(transform.position, puntosDePatrulla[puntoActual].position) < 0.1f)
        {
            puntoActual = (puntoActual + 1) % puntosDePatrulla.Count; // Cambiamos Length por Count
        }
    }

}

