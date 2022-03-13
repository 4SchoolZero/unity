using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            rb.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            rb.velocity = new Vector3(-5, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector3(0, 5, 0);
        }
    }
}
