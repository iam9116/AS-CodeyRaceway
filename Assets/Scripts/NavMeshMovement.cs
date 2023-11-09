using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public Transform goal;
    private Animator animator;
    private NavMeshAgent agent;

    public float speed = 50f;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        GameObject obstacle = GameObject.FindGameObjectsWithTag("Obstacles")[0];
        agent.destination = obstacle.transform.position;

    }

// Update is called once per frame
    void Update()
    {
        //Debug.Log(agent.destination);
        //Vector3 direction = transform.forward * Time.deltaTime * speed;
        //rb.velocity = direction;
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
