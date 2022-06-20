using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawPatrol : MonoBehaviour
{
    public Transform[] wayPoints;
    public int speed;

    private int wayPointIndex;
    private float dista;

    void Start()
    {
        wayPointIndex = 0;
        transform.LookAt(wayPoints[wayPointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        dista = Vector3.Distance(transform.position, wayPoints[wayPointIndex].position);
        if(dista < 1f)
        {
            IncreaseIndex();
        }
        Patrol();
    }


    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        wayPointIndex++;
        if(wayPointIndex >= wayPoints.Length)
        {
            wayPointIndex = 0;
        }

        transform.LookAt(wayPoints[wayPointIndex].position);
    }
}
