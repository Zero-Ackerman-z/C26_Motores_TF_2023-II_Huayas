using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public PlayerInput _playerInput;

    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        Vector2 movementInput = _playerInput.actions["Move"].ReadValue<Vector2>();
        MovePlayer(movementInput);
    }

    void MovePlayer(Vector2 direction)
    {
        Vector3 movement = new Vector3(direction.x, 0f, direction.y) * Time.deltaTime;
        transform.Translate(movement);
    }


}

