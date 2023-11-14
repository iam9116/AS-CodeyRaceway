using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CodeyMove : MonoBehaviour
{
    Animator anim;
    public float Speed = 15f;
    public float _rotationSpeed = 50f;
    public bool running = false;
    public bool canMove = true;
    public Vector3 move;

    private Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
    void Update()
    {
        if (canMove)
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");            
            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            move = (transform.forward * vertical * Speed) * Time.deltaTime;
            transform.Rotate(rotation);

            rb.AddForce(move, ForceMode.VelocityChange);

            anim.SetBool("isRunning", move != Vector3.zero);
        }

        if (gameObject.transform.position.y < 0.455)
        {
            rb.AddForce(Vector3.up * 3);
        }

        Debug.Log(Speed);
    }
}