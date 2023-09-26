using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerInput _input;
    [SerializeField]
    private AgentMover _movement;
    [SerializeField]
    private AgentAnimation _agentAnimation;


    private void Start()
    {
        _input.OnMouseClick += _movement.SetDestination;
        _movement.OnSpeedChanged += _agentAnimation.SetSpeed;
        _movement.OnStartJump.AddListener(_agentAnimation.Jump);
        _agentAnimation.SetSpeed(0);
    }

}
