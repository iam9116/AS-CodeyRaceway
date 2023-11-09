using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    public float speed = 50f;
    
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = transform.forward * Time.deltaTime * speed;
        rb.velocity = direction;

        //transform.position += transform.forward * Time.deltaTime * 50f;
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
