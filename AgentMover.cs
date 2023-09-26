using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMover : MonoBehaviour
{
    [SerializeField]
    private NavMeshAgent _Agent;

    public event Action<float> OnSpeedChanged;

    public void SetDestination(Vector3 destination)
    {
        _Agent.destination = destination;
    }

    private void Update()
    {
        OnSpeedChanged?.Invoke(
            Mathf.Clamp01(_Agent.velocity.magnitude / _Agent.speed));
    }

}
