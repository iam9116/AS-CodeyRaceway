using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;
    private GameObject[] Obstacles;

    public float speed = 50f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        if (Obstacles.Length > 0)
        {
            agent.SetDestination(Obstacles[0].transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        if (agent.remainingDistance < 0.5f && Obstacles.Length > 0)
        {
            //Destroy(Obstacles[0]);
            Obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
            if (Obstacles.Length > 0)
            {
                agent.SetDestination(Obstacles[0].transform.position);
            }
        }
    }

private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.gameObject.name);

        //Will check if the collided obstacle is an obstacle
        if (collision.gameObject.tag == "Obstacles")
        {
            //Destroy the obstacle
            Destroy(collision.gameObject);

            //Destroy the projectile
            Destroy(gameObject);
        }
    }
}
