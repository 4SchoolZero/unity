using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    public bool isgrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)){
            rb.velocity = new Vector3(7, 0, 0);
            GetComponent<Animator>().Play("walkAnimation");
        }
        if (Input.GetKeyDown(KeyCode.A)){
            rb.velocity = new Vector3(-7, 0, 0);
            GetComponent<Animator>().Play("walkAnimation");
        }
        if (Input.GetKeyDown(KeyCode.F)){
            GetComponent<Animator>().Play("punchAnimation");
            stamina.instance.UseStamina(10);
        }
        if (Input.GetKeyDown(KeyCode.Space)&& isgrounded == true){
            stamina.instance.UseStamina(20);
            rb.velocity = new Vector3(0, 5, 0);
            isgrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isgrounded = true;
        }
    }
}