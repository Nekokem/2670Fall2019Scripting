using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIwithNavMesh : MonoBehaviour, IRun
{
    private NavMeshAgent agent;
    public Transform player;
    public Transform destination;
    void Start()
    {
        destination = transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    void Update()
    {
        agent.destination = destination.position;
    }

    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("Ran");
    }

    public void Run(float f)
    {
        throw new NotImplementedException();
    }
}
