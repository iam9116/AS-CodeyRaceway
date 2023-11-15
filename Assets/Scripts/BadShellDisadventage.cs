using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadShellDisadventage : MonoBehaviour
{
    public CodeyMove codeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm alive@!!");
        codeSpeed = GameObject.FindGameObjectWithTag("Player").GetComponent<CodeyMove>();
        codeSpeed.Speed = 75f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tracks")
        {
            Debug.Log("I'm HIT@!!");
        }
    }
}

