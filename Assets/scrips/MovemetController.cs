using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MovemetController : MonoBehaviour
{

    Vector2 playerInput;
    public float moveSpeed;
    private Rigidbody rb;
    GameObject playerParent;
    public float walkSpeed;
    public float runSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

       
    }

    // Resto del código sigue igual...
}

