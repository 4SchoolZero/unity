using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public Animator player;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter(Collider other){
            player.Play("pickupAnimation");
            stamina.instance.UseStamina(-100);
            Destroy(gameObject);
            Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
