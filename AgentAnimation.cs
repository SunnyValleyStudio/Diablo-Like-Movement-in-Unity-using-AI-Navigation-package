using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AgentAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private string _movementSpeed = "MovementSpeed",
        jump = "Jump";

    public UnityEvent OnStep;

    public void SetSpeed(float speed)
    {
        _animator.SetFloat(_movementSpeed, speed);
    }

    public void Jump()
    {
        _animator.SetTrigger(jump);
    }

    public void StepEvent()
    {
        OnStep.Invoke();
    }
}
