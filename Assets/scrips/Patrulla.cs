using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrulla : MonoBehaviour
{
    SimpleLinkedList<PatrolPoint> patrolPoints = new SimpleLinkedList<PatrolPoint>();

    void Start()
    {
        // Define los puntos de patrulla
        PatrolPoint point1 = new PatrolPoint(new Vector3(1, 0, 0));
        PatrolPoint point2 = new PatrolPoint(new Vector3(0, 1, 0));
        PatrolPoint point3 = new PatrolPoint(new Vector3(0, 0, 1));

        // Agrega los puntos a la lista de patrulla
        patrolPoints.InsertAtStart(point3);
        patrolPoints.InsertAtStart(point2);
        patrolPoints.InsertAtStart(point1);

        // Muestra los puntos de patrulla en la consola (esto es opcional)
        patrolPoints.DisplayPatrolPoints();
    }
}
