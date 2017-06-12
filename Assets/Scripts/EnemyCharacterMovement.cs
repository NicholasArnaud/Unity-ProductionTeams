using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator), typeof(Rigidbody), typeof(NavMeshAgent))]
public class EnemyCharacterMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator animator;
    private readonly int SPEED = Animator.StringToHash("speed");
    public Transform target;
    private void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.destination = target.position;
        animator.SetFloat(SPEED, agent.velocity.magnitude);
    }
}
