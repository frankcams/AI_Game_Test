using UnityEngine;
using UnityEngine.AI;

public class NavScripts : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    private Animator animator;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && agent != null)
        {
            agent.SetDestination(target.position);
            
            // Handle animation based on movement
            if (animator != null)
            {
                // Check if agent is actively moving toward destination
                bool isMoving = agent.hasPath && agent.remainingDistance > agent.stoppingDistance;
                animator.SetBool("IsRunning", isMoving);
            }
        }
    }
}
