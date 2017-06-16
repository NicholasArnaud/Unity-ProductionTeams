using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator), typeof(Rigidbody), typeof(NavMeshAgent))]
public class EnemyCharacterMovement : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;


    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    private void Update()
    {
        agent.destination = target.position;
    }
}
