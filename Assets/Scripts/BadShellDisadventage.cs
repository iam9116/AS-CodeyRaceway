using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadShellDisadventage : MonoBehaviour
{
    CodeyMove codeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        codeSpeed = GameObject.Find("Codey").GetComponent<CodeyMove>();
        codeSpeed.Speed = 75f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

