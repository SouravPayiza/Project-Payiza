using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAgent : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator agent_Anim;

    public Transform[] waypoint;
    private int waypointIndex = 0;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        GetNextWaypoint();
    }
    void Update()
    {
        agent.speed = 2f;

        if (agent.remainingDistance < 0.5f)
        {
            GetNextWaypoint();
        }
    }

    private void GetNextWaypoint()
    {
        agent.SetDestination(waypoint[waypointIndex].position);
        waypointIndex++;

        if (waypointIndex == waypoint.Length)
        {
            waypointIndex = 0;
        }
    }
}
