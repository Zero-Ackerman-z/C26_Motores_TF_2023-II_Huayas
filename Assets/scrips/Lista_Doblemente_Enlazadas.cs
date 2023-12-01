using System;
using UnityEngine;

public class PatrolPoint
{
    public Vector3 position;

    public PatrolPoint(Vector3 pos)
    {
        position = pos;
    }
}

public class SimpleLinkedList<T>
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

    private Node Head { get; set; }
    private int length = 0;

    public void InsertAtStart(T value)
    {
        Node newNode = new Node(value);
        newNode.Next = Head;
        Head = newNode;
        length++;
    }

    public int GetCapacity()
    {
        return length;
    }

    public void DisplayPatrolPoints()
    {
        Node current = Head;
        while (current != null)
        {
            Debug.Log("Patrol point: " + current.Value);
            current = current.Next;
        }
    }
}

