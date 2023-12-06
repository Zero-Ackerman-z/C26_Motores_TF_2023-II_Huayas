using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class PantallaPrincipal : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            IrAlMenu();
        }
    }

    void IrAlMenu()
    {
        SceneManager.LoadScene("Menu"); // Reemplaza "Menu" con el nombre de tu escena del menú
    }
}

