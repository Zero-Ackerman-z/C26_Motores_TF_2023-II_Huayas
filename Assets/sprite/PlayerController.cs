using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del jugador
    public float interactionDistance = 2f; // Distancia máxima para interactuar con objetos
    public float attackCooldown = 1.5f; // Tiempo de espera entre ataques
    public GameObject[] interactableObjects; // Lista de objetos interactuables

    private GameObject objectInHand; // Objeto que el jugador está sosteniendo
    private float currentCooldown = 0f; // Tiempo actual de espera entre ataques
    private bool buttonEventActive = false; // Estado del evento del botón

    void Update()
    {
        // Movimiento del jugador
        MovePlayer();

        // Ataque al presionar la tecla 'X'
        Attack();
       
    }

    void MovePlayer()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

       
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * speed * Time.deltaTime;

        //movimiento al jugador
        transform.Translate(movement);
    }

    void Attack()
    {
        // Verificar el cooldown de ataque ha terminado y se presionó la tecla 'X'
        if (currentCooldown <= 0f && Input.GetKeyDown(KeyCode.X))
        {
            
            Debug.Log("boton presionado");
            // Reiniciar el cooldown del ataque
            currentCooldown = attackCooldown;
        }

        //  tiempo de cooldown
        if (currentCooldown > 0)
        {
            currentCooldown -= Time.deltaTime;
        }
    }    
}

