using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersecucionMRU : MonoBehaviour
{
    public Transform player;
    public float speed = 5f; 
    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("¡El jugador no está asignado!");
            return;
        }

        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        // Esto orientará al enemigo hacia la posición actual del jugador
        transform.LookAt(player);
    }
}
