using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pantalla_de_Carga : MonoBehaviour
{
    public string sceneToLoad = "NombreDeTuEscena"; // Coloca el nombre de la escena que deseas cargar

    void Start()
    {
        float loadTime = Random.Range(1f, 3f); // Tiempo aleatorio entre 1 y 3 segundos
        Invoke("CargarEscena", loadTime);
    }

    void CargarEscena()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
