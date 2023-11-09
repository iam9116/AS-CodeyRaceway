using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    public float speed = 100f;
    public float freq = 1f;
    public float amp = 1f;

    Vector3 posBuffer;
    // Start is called before the first frame update
    void Start()
    {
        posBuffer = transform.position;
        amp *= 0.001f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);

        posBuffer.y += Mathf.Sin(Time.fixedTime * freq) * amp;

        transform.position = posBuffer;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            Invoke("itemBoxRespawn", 3f);
        }
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
