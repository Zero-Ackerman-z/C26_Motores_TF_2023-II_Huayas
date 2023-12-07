using UnityEngine;

public class NodoLista
{
    public GameObject Valor;
    public NodoLista Siguiente;

    public NodoLista(GameObject valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class MiLista :MonoBehaviour
{
    private NodoLista cabeza;

    public void AgregarAlFinal(GameObject valor)
    {
        NodoLista nuevoNodo = new NodoLista(valor);

        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            NodoLista actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    public void MostrarGameObjects()
    {
        NodoLista actual = cabeza;
        while (actual != null)
        {
            Debug.Log("Game Object: " + actual.Valor.name);
            actual = actual.Siguiente;
        }
    }
}