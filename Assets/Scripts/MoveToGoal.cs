using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
