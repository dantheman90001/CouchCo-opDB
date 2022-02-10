using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    GameObject currentWayPoint;
    GameObject previousWaypoint;
    GameObject[] allWaypoints;
    bool travelling;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        allWaypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        currentWayPoint = GetRandomWaypoint();
        SetDestination();
    }

    // Update is called once per frame
    void Update()
    {

        if (travelling && navMeshAgent.remainingDistance <= 1f)
        {
            travelling = false;
            SetDestination();
        }
    }

    GameObject GetRandomWaypoint()
    {
        if (allWaypoints.Length == 0)
        {
            return null;
        }
        else
        {
            int index = Random.Range(0, allWaypoints.Length);
            return allWaypoints[index];
        }
    }

    void SetDestination()
    {
        previousWaypoint = currentWayPoint;
        currentWayPoint = GetRandomWaypoint();

        Vector3 targetVector = currentWayPoint.transform.position;
        navMeshAgent.SetDestination(targetVector);
        travelling = true;

    }
}
