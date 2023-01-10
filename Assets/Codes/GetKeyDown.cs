using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyDown : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0, 0, 10000 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-1000, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(0, 0, -10000 * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(1000, 0, 0 * Time.deltaTime);
        }

    }
}
