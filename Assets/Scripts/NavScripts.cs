using UnityEngine;
using UnityEngine.AI;

public class NavScripts : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null && agent != null)
        {
            agent.SetDestination(target.position);
        }
    }
}
