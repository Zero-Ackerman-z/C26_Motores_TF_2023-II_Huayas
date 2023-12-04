using System.Collections.Generic;
using UnityEngine; // Asegúrate de tener esta directiva

public class GameLogic : MonoBehaviour
{
    MiLista miLista = new MiLista();

    void Start()
    {
        GameObject obj1 = GameObject.Find("Object1");
        GameObject obj2 = GameObject.Find("Object2");

        miLista.AgregarAlFinal(obj1);
        miLista.AgregarAlFinal(obj2);

        miLista.MostrarGameObjects();
    }
}
