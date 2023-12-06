using UnityEngine;
namespace EstructurasDatosJuego
{
    public class CircularLinkedList<T>
    {
        class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node Head;
        private int Capacity = 0;

        public void InsertNodeAtStart(T value)
        {
            if (Head == null)
            {
                Node newNode = new Node(value);
                Head = newNode;
                newNode.Next = Head;
                Capacity++;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Node lastNode = Head;
                while (lastNode.Next != Head)
                {
                    lastNode = lastNode.Next;
                }

                lastNode.Next = newNode;
                Head = newNode;
                Capacity++;
            }
        }

        // Implementa el resto de las funciones según sea necesario para tu lógica de juego

        public void PrintAllNodes()
        {
            Node tmp = Head;
            if (Head == null)
            {
                Debug.Log("La lista está vacía.");
                return;
            }
            do
            {
                Debug.Log(((GameObject)(object)tmp.Value).name); // Accede al nombre del GameObject
                tmp = tmp.Next;
            } while (tmp != Head);
        }
    }
}